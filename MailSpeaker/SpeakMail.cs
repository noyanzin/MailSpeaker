using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSpeaker
{
    public class SpeakMail
    {
        private IWebDriver browser;
        private IWebElement webElement, btnSynthesize, btnPlay, chkTerms, languages;
        private WebDriverWait wait;
        public void StartBrowser()
        {
            browser = new OpenQA.Selenium.Firefox.FirefoxDriver();
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("https://www.acapela-group.com/demos/");
            wait = new WebDriverWait(browser, TimeSpan.FromSeconds(60));
            webElement = wait.Until(e=>e.FindElement(By.Id("voices_tts")));
            chkTerms = wait.Until(e => e.FindElement(By.Id("label_voices_terms")));
            btnSynthesize = wait.Until(e => e.FindElement(By.Id("voices_submit")));
            btnPlay = wait.Until(e => e.FindElement(By.ClassName("play-btn")));
        }
        public string SelectLanguage()
        {
            languages = browser.FindElement(By.Name("voices_languages"));
            IWebElement language = languages.FindElement(By.XPath("//option[@value='sonid26']"));
            language.Click();
            return language.Text;
        }

        public string SelectVoice()
        {
            IWebElement voices = browser.FindElement(By.XPath("//select[@name='voices_voice']"));
            IWebElement voice = voices.FindElement(By.XPath("//option[@value='Lena (premium voice)']"));
            voice.Click();
            return voice.Text;
        }
        public void FillTextArea(string textToSpeak)
        {
           webElement.Clear();
           webElement.SendKeys(textToSpeak);
        }
        public void Synthesize()
        {
            btnSynthesize.Click();
        }
        public void DefaultText()
        {
            IWebElement element = browser.FindElement(By.ClassName("checkmark"));
            if(!element.Selected) element.Click();
        }
        public void Agree()
        {
            IWebElement element = browser.FindElements(By.ClassName("checkmark"))[1];
            if(!element.Selected) element.Click();
                
               
        }


        public void Play()
        {
            wait.Until(e=>e.FindElement(By.ClassName("play-btn")).Displayed);
            btnPlay.Click();
            string findingPlayer = "div.player-time span.current";
            wait.Until(e => e.FindElement(By.CssSelector(findingPlayer)).Text != "00:00");
            wait.Until(e => e.FindElement(By.CssSelector(findingPlayer)).Text == "00:00");
            
        }
        public void StopBrowser()
        {
            browser.Quit();
        }
    }
}
