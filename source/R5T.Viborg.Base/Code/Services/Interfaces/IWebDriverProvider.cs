using System;

using OpenQA.Selenium;


namespace R5T.Viborg
{
    public interface IWebDriverProvider
    {
        IWebDriver GetWebDriver();
    }
}
