// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class PoliceAccountTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), new ChromeOptions().ToCapabilities());
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void policeAccount() {
    // Test name: PoliceAccount
    // Step # | name | target | value
    // 1 | open | https://localhost:44300/Police | 
    driver.Navigate().GoToUrl("https://localhost:44300/Police");
    // 2 | setWindowSize | 1552x849 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 849);
    // 3 | click | linkText=Log off | 
    driver.FindElement(By.LinkText("Log off")).Click();
    // 4 | close |  | 
    driver.Close();
  }
}
