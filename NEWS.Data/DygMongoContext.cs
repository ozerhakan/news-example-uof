using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NEWS.Core;
using NEWS.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace NEWS.Data
{
    public class NEWSMongoContext : INEWSMongoContext
    {
        private IMongoDatabase _db { get; set; }
        private IMongoClient _mongoClient { get; set; }
        private readonly List<Func<Task>> _commands;
        private IClientSession Session { get; set; }
        private readonly IConfiguration _configuration;

        public NEWSMongoContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _commands = new List<Func<Task>>();
        }

        private void ConfigureMongo()
        {
            if (_mongoClient != null)
            {
                return;
            }

            _mongoClient = new MongoClient(_configuration["MongoSettings:Connection"]);
            _db = _mongoClient.GetDatabase(_configuration["MongoSettings:DatabaseName"]);
        }
        
        public async Task<int> SaveChanges()
        {
            using (Session = await _mongoClient.StartSessionAsync())
            {
                Session.StartTransaction();
                var commandTasks = _commands.Select(c => c());
                await Task.WhenAll(commandTasks);
                await Session.CommitTransactionAsync();
            }

            return _commands.Count;
        }
        
        public IMongoCollection<T> GetCollection<T>(string name)
        {
            ConfigureMongo();
            return _db.GetCollection<T>(name);
        }
        
        public void AddCommand(Func<Task> func)
        {
            _commands.Add(func);
        }
        
        public void Dispose()
        {
            while (Session != null && Session.IsInTransaction)
                Thread.Sleep(TimeSpan.FromMilliseconds(100));

            GC.SuppressFinalize(this);
        }
    }
}