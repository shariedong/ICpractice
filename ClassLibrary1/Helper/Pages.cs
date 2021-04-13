using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary1
{
    //管理各个页面
    public class Pages
    {
        public static Homepage Homepage
        {
            get
            {
                var homepage = new Homepage();
                PageFactory.InitElements(Browser.Driver, homepage);
                return homepage;
            }
        }
        public static LoginPage LoginPage
        {
            get
            {
                var loginpage = new LoginPage();
                PageFactory.InitElements(Browser.Driver, loginpage);
                return loginpage;
            }
        }
        public static ProfilePage ProfilePage
        {
            get
            {
                var profilepage = new ProfilePage();
                PageFactory.InitElements(Browser.Driver, profilepage);
                return profilepage;
            }
        }

    }
}
