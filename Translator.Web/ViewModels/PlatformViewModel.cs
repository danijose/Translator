using System.Collections.Generic;
using Translator.Web.Models;

namespace Translator.Web.ViewModels
{
    public class PlatformViewModel
    {
        public string Title { get; set; }
        public List<Platform> Platforms { get; set; }
    }
}
