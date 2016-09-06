using DynamicSlider.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace DynamicSlider.Controllers
{
    public class PicturesController : ApiController
    {
        public static int Count { get; private set; }

        [HttpGet]
        public List<string> Get()
        {
            PicturesFactory pictures = new PicturesFactory();
            Count = pictures.Count;
            return pictures.Pictures;
        }
    }
}
