using System;
using System.Security.Permissions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestLearning;
using TestLearning.Assembly;

namespace Test
{
    [TestFixture]
    public class MyFirstPOMTest
    {
        [SetUp]
        public void StartUpTest()
        {
            Browsers.Init();
        }
        [TearDown]
        public void EndTest()
        {
            Browsers.Close();
        }

        [Test]
        public void HelloWorldTest()
        {
            Pages.home.isAt();
            Pages.home.EnterSearchText("Hello World");
        }
    }
}