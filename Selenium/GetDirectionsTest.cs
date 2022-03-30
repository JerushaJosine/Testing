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
public class GetDirectionsTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), new FirefoxOptions().ToCapabilities());
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void getDirections() {
    // Test name: Get Directions
    // Step # | name | target | value
    // 1 | open | https://localhost:44300/ | 
    driver.Navigate().GoToUrl("https://localhost:44300/");
    // 2 | setWindowSize | 1148x692 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1148, 692);
    // 3 | mouseOver | linkText=usama.anwar@gmail.com! | 
    {
      var element = driver.FindElement(By.LinkText("usama.anwar@gmail.com!"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 4 | click | css=div:nth-child(3) > div > img | 
    driver.FindElement(By.CssSelector("div:nth-child(3) > div > img")).Click();
    // 5 | close |  | 
    driver.Close();
    // 6 | runScript | window.scrollTo(0,1.600000023841858) | 
    js.ExecuteScript("window.scrollTo(0,1.600000023841858)");
    // 7 | click | css=div:nth-child(3) > div > img | 
    driver.FindElement(By.CssSelector("div:nth-child(3) > div > img")).Click();
    // 8 | click | id=direction | 
    driver.FindElement(By.Id("direction")).Click();
    // 9 | mouseOver | id=direction | 
    {
      var element = driver.FindElement(By.Id("direction"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 10 | mouseOut | id=direction | 
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    // 11 | mouseOver | css=.gm-ui-hover-effect | 
    {
      var element = driver.FindElement(By.CssSelector(".gm-ui-hover-effect"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 12 | click | css=.gm-ui-hover-effect | 
    driver.FindElement(By.CssSelector(".gm-ui-hover-effect")).Click();
    // 13 | runScript | window.scrollTo(0,162.39999389648438) | 
    js.ExecuteScript("window.scrollTo(0,162.39999389648438)");
    // 14 | mouseDownAt | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 332,561
    {
      var element = driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    // 15 | mouseMoveAt | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 332,561
    {
      var element = driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 16 | mouseUpAt | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 332,561
    {
      var element = driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    // 17 | click | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 
    driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)")).Click();
    // 18 | mouseDownAt | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 748,235
    {
      var element = driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    // 19 | mouseMoveAt | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 748,235
    {
      var element = driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 20 | mouseUpAt | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 748,235
    {
      var element = driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    // 21 | click | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 
    driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)")).Click();
    // 22 | mouseDownAt | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 562,191
    {
      var element = driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    // 23 | mouseMoveAt | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 562,191
    {
      var element = driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 24 | mouseUpAt | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 562,191
    {
      var element = driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    // 25 | click | css=.gm-style > div:nth-child(2) > div:nth-child(2) | 
    driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2) > div:nth-child(2)")).Click();
    // 26 | runScript | window.scrollTo(0,7.199999809265137) | 
    js.ExecuteScript("window.scrollTo(0,7.199999809265137)");
    // 27 | click | css=.gm-style > div:nth-child(2) | 
    driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2)")).Click();
    // 28 | mouseOver | linkText=E-Park. | 
    {
      var element = driver.FindElement(By.LinkText("E-Park."));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 29 | mouseOut | linkText=E-Park. | 
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    // 30 | click | css=.gm-style > div:nth-child(2) | 
    driver.FindElement(By.CssSelector(".gm-style > div:nth-child(2)")).Click();
    // 31 | mouseOver | linkText=usama.anwar@gmail.com! | 
    {
      var element = driver.FindElement(By.LinkText("usama.anwar@gmail.com!"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
  }
}