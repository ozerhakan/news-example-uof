using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using DYG.Core;
using DYG.Core.Services;
using DYG.UI.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DYG.UI.Models;

namespace DYG.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsServices _newsServices;
        private readonly IMapper _mapper;

        public HomeController(INewsServices newsServices, ILogger<HomeController> logger , IMapper mapper)
        {
            _logger = logger;
            _newsServices = newsServices;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            // var input = new NewsDTO()
            // {
            //     Title = "Davutoğlu, Özel Kuvvetler Komutanlığını ziyaret etti",
            //     Spot = "Başbakan Ahmet Davutoğlu, Ankara'nın Gölbaşı ilçesinde yer alan Özel Kuvvetler Komutanlığını ziyaret etti",
            //     PublishedTime = DateTime.Now,
            //     CreatedTime = DateTime.Now,
            //     NewsKeywords = new List<string>() {"2", "3"},
            //     MainCategory = new MainCategoryDTO()
            //     {
            //         Title = "Türkiye",
            //         Slug = "turkiye"
            //     },
            //     SourcesData = new List<SourcesDataDTO>()
            //     
            // };
            //
            // var newsData = _mapper.Map<NewsDTO, News>(input);
            //
            // _newsServices.CreateNews(newsData);
            var myJsonString = System.IO.File.ReadAllText("/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/case_study.data.json");
            List<NewsDTO> model = JsonSerializer.Deserialize<List<NewsDTO>>(myJsonString);
            return View(model);
        }

        [Route("{mainCategory}/{title},{id}",Order = 1)]
        public IActionResult Detail(string mainCategory,string title, string id)
        {
            if (string.IsNullOrEmpty(id))
                return RedirectPermanent("404");

            if (string.IsNullOrEmpty(mainCategory))
                return RedirectPermanent("ntv.com.tr");
            //(DYG.UI.Domain.Helpers.Helper.GetUrl(item.MainCategory.Slug,item.Title,item.Id)
            
            var myJsonString = System.IO.File.ReadAllText("/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/case_study.data.json");
            List<NewsDTO> newsList = JsonSerializer.Deserialize<List<NewsDTO>>(myJsonString);

            var newsDetail = newsList.FirstOrDefault(news => news.Id == id);
            if (newsDetail == null)
                return RedirectPermanent("ntv.com.tr");
            
            return View(newsDetail);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}