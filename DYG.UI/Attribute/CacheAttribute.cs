using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;

namespace DYG.UI.Attribute
{
    public class CacheAttribute : System.Attribute
    {
        public string Key { get; set; }
        
        public string OnBefore(MethodInfo targetMethod, object[] args, IDistributedCache distributedCache)
        {
            return  distributedCache.GetString(Key);
        }

        public void OnAfter(MethodInfo targetMethod, object[] args, object value, IDistributedCache distributedCache)
        {
            distributedCache.SetString(Key, JsonSerializer.Serialize(value));
        }    
        
        public interface ICacheAttribute
        {
            string OnBefore(MethodInfo targetMethod, object[] args, IDistributedCache distributedCache);
            void  OnAfter(MethodInfo targetMethod,  object[] args, object value,  IDistributedCache distributedCache);
        }
    }
}