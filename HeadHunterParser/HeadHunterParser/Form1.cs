using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HeadHunterParser
{
    public partial class Form1 : Form
    {
        public void file(string s)
        {
            string path = @"..\TitleYouTube.txt";
            if (File.Exists(path))
            {
                //File.Delete(path);
            }
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                //byte[] buffer = Encoding.Default.GetBytes(text);
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                
                    byte[] buffer = new UTF8Encoding(true).GetBytes($"{s}\n");
                    fs.Write(buffer, 0, buffer.Length);
            }
        }
        public Form1()
        {
            InitializeComponent();
            AddNeed.Click += (s, e) =>
            {
                if(dataGridViewAdd.Columns.Count==0) dataGridViewAdd.Columns.Add("1", "add");
                file(textAdd.Text);
                dataGridViewAdd.Rows.Add(textAdd.Text);
            };
            DelNeed.Click += (s, e) =>
            {
                if (dataGridViewAdd.Columns.Count == 0) dataGridViewAdd.Columns.Add("1", "add");
                //dataGridViewAdd.
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        struct Cells
        {
            string Name { get; set; }
            double Price { get; set; }
            int Value { get; set; }
        }
        struct Groups
        {
            public string Name { get; set; }
            public int Code { get; set; }
            public string Ed { get; set; }
            public string Price { get; set; }
            public int Value { get; set; }
        }
        string site = "https://krasnodar.hh.ru/account/login?backurl=%2F&hhtmFrom=main";

        private void button1_Click(object sender, EventArgs e)
        {
            //Selenium(site);
            ParserResponsesHH parser = new ParserResponsesHH("https://krasnodar.hh.ru/account/login?backurl=%2F&hhtmFrom=main");
            parser.Parser();
            
        }
        //class SeleniumParserMakeup : Form1
        //{
        ChromeDriver driver;
        //public SeleniumParserMakeup(string link)
        //{
        //    Connect(link);
        //}
        void wait(IWebDriver driver, By by)
        {
            while (true)
            {
                if (driver.FindElements(by).Count > 0) { break; }
            }
        }
        void waitClick(IWebDriver driver, By by)
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
            //j++;
            return new Groups
            {
                Name = name,
                Code = Convert.ToInt32(d.FindElement(By.XPath(".//td[3]")).Text),
                Ed = d.FindElement(By.XPath(".//td[7]")).Text,
                Price = d.FindElement(By.XPath(".//td[13]")).Text,
                Value = Convert.ToInt32(d.FindElement(By.XPath(".//td[22]")).Text)
            };
        }
        void Connect(string link)
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
        void Login(ChromeDriver driver)
        {
            while (true)
            {
                try
                {
                    driver.FindElement(By.XPath("//button[1]"));
                    break;
                }
                catch{ }
            }

            while (true)
            {
                try
                {
                    driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("nadinos77@mail.ru");
                    break;
                }
                catch
                {

                }
            }
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("romaska1409");
            driver.FindElement(By.XPath("//button[1]")).Click();
        }

        public async void Selenium(string s)
        {
            Connect(s);
            driver.FindElement(By.XPath("//input[@name='login']")).SendKeys("roma.ostroumov98@mail.ru");
            driver.FindElement(By.XPath("//div[@class='account-login-actions']/button[@class='bloko-link bloko-link_pseudo']")).Click();
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("ifuckyourhh1000times.");

            while (true)
            {
                if (driver.FindElements(By.XPath("//a[@class='bloko-button']")).Count > 0) break;
            }
            waitClick(driver, By.XPath("//a[@class='bloko-button']"));
            



            //Login(driver);

            //            waitClick(driver, By.XPath("//div[@class='items']/div/div/div[2]"));

            //            wait(driver, By.ClassName("group-title"));//

            //            List<Cells> cells = new List<Cells>();
            //            List<List<Groups>> groups = new List<List<Groups>>();
            //            List<string> types = new List<string>();
            //            int i = 1;
            //            Thread.Sleep(1000);
            //            int progresmax = Convert.ToInt32(driver.FindElement(By.XPath(
            //                @"//div[@class='floating fluid icon basic button catalog-multi-actions-dropdown ui dropdown action-activate']/span")).Text.Replace("Действия", "").Replace("поз.", ""));

            //            progressBar1.Maximum = progresmax;
            //            int progres = 0;
            //            label1.Text = $"{progres}/{progresmax}";
            //            string text = $"//tbody/tr[{i}]";
            //            wait(driver, By.XPath(text));
            //            //int element = 1;
            //            while (driver.FindElements(By.XPath(text)).Count != 0)
            //            {
            //                string categori = driver.FindElement(By.XPath(text)).Text;
            //                types.Add(categori);
            //                listBox1.Items.Add("--------------------");
            //                listBox1.Items.Add(categori);
            //                listBox1.Items.Add("--------------------");
            //                waitClick(driver, By.XPath(text));
            //                int page = 1;
            //                List<Groups> group = new List<Groups>();
            //                while (true)
            //                {
            //                    //await Task.Run(()=>
            //                    //{
            //                    //group.AddRange(driver.FindElements(By.XPath("//tr[@class='table-row']")).
            //                    //    Select(d => pus(d, progres, elementCatalog++,
            //                    //    progressBar1, listBox1, label1)));

            //                    ////    driver.FindElements(By.XPath("//tr[@class='table-row']")).
            //                    ////        AsParallel().ForAll(d => { group.Add(pus(d, progres, elementCatalog++)); });
            //                    //}
            //                    //);
            //                    await Task.Run(() =>
            //                    {
            //                        driver.FindElements(By.XPath("//tr[@class='table-row']")).
            //       AsParallel().Select((d, i) => new { elementCatalog = (page - 1) * 100 + i + 1 , driver = d }).
            //       ForAll(x => { group.Add(pus(x.driver, progres++, progresmax, x.elementCatalog)); });
            //                    }
            //                    );
            //                    //foreach (var g in driver.FindElements(By.XPath("//tr[@class='table-row']")))
            //                    //{
            //                    //listBox1.Items.Add('3');
            //                    //string name = g.FindElement(By.XPath(".//td[2]")).Text;
            //                    //Groups group = new Groups();
            //                    //group.Name = name;
            //                    //group.Code = Convert.ToInt32(g.FindElement(By.XPath(".//td[3]")).Text);
            //                    //group.Ed = g.FindElement(By.XPath(".//td[7]")).Text;
            //                    //group.Price = g.FindElement(By.XPath(".//td[13]")).Text;
            //                    //group.Value = Convert.ToInt32(g.FindElement(By.XPath(".//td[22]")).Text);

            //                    //groups.Add(group);
            //                    //progressBar1.Value++;
            //                    //progres.Pop();
            //                    //progres.Push(element++);
            //                    //label1.Text = String.Join("/", progres);
            //                    //listBox1.Items.Add(j + ": " + name);
            //                    //j++;
            //                    //}
            //                    //text = f"//div[@class='ui small pagination menu']/a[@class='item'][{page}]"
            //                    if (Equals(0, driver.FindElements(By.XPath($"//div[@class='ui small pagination menu']/a[@class='item'][{page}]")).Count))
            //                    {
            //                        break;
            //                    }
            //                    driver.FindElement(By.XPath($"//div[@class='ui small pagination menu']/a[@class='item'][{page}]")).Click();
            //                    page++;
            //                }
            //                groups.Add(group);
            //                i++;
            //                text = $"//tbody/tr[{i}]";
            //                waitClick(driver, By.XPath("//ul[@class='catalog-groups-breadcrumbs']/li"));


            //            }
            //            driver.Close();
            //            foreach (var item in types.Zip(groups, (t, g) => new { type = t, group = g }))
            //            {
            //                listBox1.Items.Add(item.type);
            //                i = 1;
            //                foreach (var x in item.group)
            //                {
            //                    listBox1.Items.Add($@"{i++}: Name: {x.Name} Code: {x.Code} 
            //Ed: {x.Ed} Price: {x.Price} Value: {x.Value}");
            //                }

            //            }
            //            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            //            listBox1.SelectedIndex = -1;
        }
    }
}
//}
