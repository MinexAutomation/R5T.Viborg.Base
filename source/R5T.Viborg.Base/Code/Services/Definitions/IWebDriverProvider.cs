using System;

using OpenQA.Selenium;

using R5T.T0064;


namespace R5T.Viborg
{
    [ServiceDefinitionMarker]
    public interface IWebDriverProvider : IServiceDefinition
    {
        IWebDriver GetWebDriver();
    }
}
