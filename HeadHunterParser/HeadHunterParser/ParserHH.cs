using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HeadHunterParser
{
    struct Groups
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Ed { get; set; }
        public string Price { get; set; }
        public int Value { get; set; }
    }
    public abstract class ParserHH: Form1
    {

        //string site = "https://krasnodar.hh.ru/account/login?backurl=%2F&hhtmFrom=main";
        protected ChromeDriver driver;
        public ParserHH(string link)
        {
            driver = new ChromeDriver("/chromedriver/chromedriver");
            driver.Navigate().GoToUrl(link);
            driver.Manage().Window.Maximize();
            //ChromeDriverService service = ChromeDriverService.CreateDefaultService("/chromedriver/chromedriver");
            //service.HideCommandPromptWindow = true;

            //var options = new ChromeOptions();
            //options.AddArgument("--window-position=-32000,-32000");
            //this.driver = new ChromeDriver(service, options);
            //this.driver.Navigate().GoToUrl(link);
            
        }
        protected void wait(IWebDriver driver, By by)
        {
            while (true)
            {
                if (driver.FindElements(by).Count > 0) { break; }
            }
        }
        protected void waitClick(IWebDriver driver, By by)
        {
            while (true)
            {
                if (driver.FindElements(by).Count > 0)
                {
                    driver.FindElement(by).Click();
                    break;
                }
            }
        }
        Groups pus(IWebElement d, int progres, int progresmax, int j)
        {
            string name = d.FindElement(By.XPath(".//td[2]")).Text;
            progressBar1.Invoke((Action)delegate { progressBar1.Value++; });
            //progres.Pop();
            label1.Invoke((Action)delegate
            {
                label1.Text = $"{progres}/{progresmax}";
            });
            listBox1.Invoke((Action)delegate
            {
                listBox1.Items.Add(j + ": " + name);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;
            });
            j++;
            return new Groups
            {
                //Name = name,
                Code = Convert.ToInt32(d.FindElement(By.XPath(".//td[3]")).Text),
                Ed = d.FindElement(By.XPath(".//td[7]")).Text,
                Price = d.FindElement(By.XPath(".//td[13]")).Text,
                Value = Convert.ToInt32(d.FindElement(By.XPath(".//td[22]")).Text)
            };
        }
        public abstract void Parser();
        protected void Login()
        {
            driver.FindElement(By.XPath("//input[@name='login']")).SendKeys("roma.ostroumov98@mail.ru");
            driver.FindElement(By.XPath("//div[@class='account-login-actions']/button[@class='bloko-link bloko-link_pseudo']")).Click();
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("ifuckyourhh1000times.");

            while (true)
            {
                if (driver.FindElements(By.XPath("//a[@class='bloko-button']")).Count > 0) break;
            }
        }
        public abstract void Print();
    }

    /// <summary>
    /// Просмотр откликов и их печать в ворде
    /// </summary>
    public class ParserResponsesHH : ParserHH
    {
        public ParserResponsesHH(string link) : base(link) { }
        public override void Parser()
        {
            Login();
            waitClick(driver, By.XPath("//a[@class='bloko-button']"));
        }

        public override void Print()
        {
            throw new NotImplementedException();
            //////////
            ////
            ///

        }
    }
    /// <summary>
    /// Поиск вакансий и отклики на них
    /// </summary>
    public class ParserSearchHH : ParserHH
    {
        public ParserSearchHH(string link) : base(link) { }
        public override void Parser()
        {
            throw new NotImplementedException();
            //////////
            ////
            ///
        }

        public override void Print()
        {
            throw new NotImplementedException();
            //////////
            ////
            ///
        }
    }
}
