using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using TestLearning.Pages;

namespace TestLearning.Assembly
{
    public static class Pages
    {
        private static T getPages<T>() where T: new()
        {
            var page = new T();
            PageFactory.InitElements(Browsers.getDriver, page);
            return page;
        }
        public static Home home
        {
            get { return getPages<Home>(); }
        }
    }
}
