using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestLearning.Assembly
{
    public class Browsers
    {
        private static IWebDriver webDriver;
        private static string baseURL = "https://demo.nopcommerce.com/";
        private static string browser = "Chrome";
        public static void Init()
        {
            switch(browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
            GoTo(baseURL);
        }
        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }
        public static IWebDriver getDriver
        {
            get { return webDriver; }
        }
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
