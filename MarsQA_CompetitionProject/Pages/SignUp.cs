﻿
using MarsQA_CompetitionProject.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsQA_CompetitionProject.Pages
{
    class SignUp
    {
        public SignUp()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Join tab
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
        private IWebElement JoinTab { get; set; }

        //Identify FirstName textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[1]/input")]
        private IWebElement FirstNameTextbox { get; set; }

        //Identify LastName textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[2]/input")]
        private IWebElement LastNameTextbox { get; set; }

        //Identify Email textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[3]/input")]
        private IWebElement EmailTextbox { get; set; }

        //Identify Password textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[4]/input")]
        private IWebElement PasswordTextbox { get; set; }

        //Identify Confirm Password textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[5]/input")]
        private IWebElement ConfirmPasswordTextbox { get; set; }

        //Identify Term and Conditions checkbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[6]/div/div/input")]
        private IWebElement TnCCheckbox { get; set; }

        //Identify Join button
        [FindsBy(How = How.XPath, Using = "//*[@id='submit-btn']")]
        private IWebElement JoinBtn { get; set; }
        #endregion

        internal void SignUpSteps()
        {
            //Import value from the excel data file
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignUp");

            //Click on Join tab
            JoinTab.Click();

            GlobalDefinitions.wait(5);

            //Enter firstName
            FirstNameTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "FirstName"));

            //Enter lastName
            LastNameTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));

            //Enter email
            EmailTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Email"));

            //Enter password
            PasswordTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Enter password again to confirm
            ConfirmPasswordTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPswd"));

            //Tick Term and Conditions checkbox 
            TnCCheckbox.Click();

            //Click on join button
            JoinBtn.Click();


        }
    }
}
