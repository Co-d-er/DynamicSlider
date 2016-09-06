using System;
using System.Web.Http;

namespace DynamicSlider.Controllers
{
    public class RandomController : ApiController
    {
        [HttpGet]
        public int Get()
        {
            Random rand = new Random();
            int result = rand.Next(0, PicturesController.Count);
            return result;
        }
    }
}
