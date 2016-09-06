using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DynamicSlider.Models
{
    public class PicturesFactory
    {
        public int Count { get; private set; }
        public List<string> Pictures { get; private set; } = new List<string>();

        public PicturesFactory()
        {
            string rootPath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + @"scripts/app/pictures";
            foreach (var r in Directory.GetFiles(rootPath).ToList())
            {
                FileInfo file = new FileInfo(r);
                Pictures.Add(@"/scripts/app/pictures/" + file.Name);
            }
            Count = Pictures.Count;
        }
    }
}