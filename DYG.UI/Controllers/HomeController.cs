using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using DYG.Core;
using DYG.UI.Attribute;
using DYG.Domain.DTO;
using DYG.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DYG.UI.Models;
using Microsoft.Extensions.Configuration;

namespace DYG.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsServices _newsServices;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public HomeController(INewsServices newsServices, ILogger<HomeController> logger, IConfiguration configuration,
            IMapper mapper)
        {
            _logger = logger;
            _newsServices = newsServices;
            _mapper = mapper;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var newsList = _newsServices.GetReadNews();
            return View(newsList);
        }

        [Route("{mainCategory}/{title},{id}", Order = 1)]
        [Cache(Key = "HomeDetailCache")]
        public IActionResult Detail(string mainCategory, string title, string id)
        {
            if (string.IsNullOrEmpty(id))
                return RedirectPermanent("404"); //404 sayfası yapılır redirect edilir.

            if (string.IsNullOrEmpty(mainCategory))
                return RedirectPermanent(_configuration.GetSection("GlobalOptions: NtvUrl").Value);

            var newsList = _newsServices.GetReadNews();
            
            var newsDetail = newsList.FirstOrDefault(news => news.Id == id);
            if (newsDetail == null)
                return RedirectPermanent(_configuration.GetSection("GlobalOptions: NtvUrl").Value);

            return View(newsDetail);
        }

        public IActionResult Feed()
        {
            var result = _newsServices.GetAllNews().Result;
            return View(result.ToList());
        }

        public IActionResult Create()
        {
            var mockInput = new NewsDTO()
            {
                Title = "Davutoğlu, Özel Kuvvetler Komutanlığını ziyaret etti",
                Spot =
                    "Başbakan Ahmet Davutoğlu, Ankara'nın Gölbaşı ilçesinde yer alan Özel Kuvvetler Komutanlığını ziyaret etti",
                PublishedTime = DateTime.Now.ToString(),
                CreatedTime = DateTime.Now.ToString(),
                NewsKeywords = new List<string>() {"2", "3"},
                MainCategory = new MainCategoryDTO()
                {
                    Title = "Türkiye",
                    Slug = "turkiye"
                },
                Story = new StoryDTO()
                {
                    Contents = new List<ContentDTO>()
                    {
                        new ContentDTO()
                        {
                            _t = "MongoDbTextContent",
                            Text =
                                "Başbakan Davutoğlu, Çankaya Köşkü'nden Gölbaşı ilçesinde yer alan Özel Kuvvetler Komutanlığına geçti"
                        },
                        new ContentDTO()
                        {
                            _t = "MongoDbImageContent",
                            ImageUrl =
                                "https://cdn1-test.ntv.com.tr/gorsel/ocacC2EjB0SRv07FOWRHpQ.jpg?width=710&height=533&mode=crop&scale=both&v=1575103859593&meta=rectangle"
                        },
                        new ContentDTO()
                        {
                            _t = "MongoDbTextContent",
                            Text =
                                "Davutoğlu, burada anı defterini imzaladıktan sonra, Türk Silahlı Kuvvetlerinin her türlü arazi ve iklim şartlarında görev yapabilecek nitelikte üst " +
                                "düzey eğitime tabi tutularak yetiştirilen ve \"bordo bereliler\" olarak bilinen Özel Kuvvetler Komutanlığının eğitim tesislerini yerinde inceledi."
                        }
                    }
                },
                MainArtUrl =
                    "http://cdn1.ntv.com.tr/gorsel/turkiye,wNHAnBFNREy16NUvmO74Wg.jpg?mode=crop&scale=both&v=20150728190350847"

            };


            _newsServices.CreateNews(mockInput);
            return View();
        }
    }
}