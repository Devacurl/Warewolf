﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Warewolf.UIBindingTests.WebSource
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class WebSourceFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Web Source.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Web Source", "\tIn order to create a web source for web services\r\n\tAs a Warewolf user\r\n\tI want t" +
                    "o be able to manage web sources easily", ProgrammingLanguage.CSharp, new string[] {
                        "WebSource"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Web Source")))
            {
                Warewolf.UIBindingTests.WebSource.WebSourceFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Creating New Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        public virtual void CreatingNewWebSource()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating New Web Source", new string[] {
                        "WebSource"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
   testRunner.Given("I open New Web Source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
   testRunner.Then("\"New Web Service Source\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
   testRunner.And("title is \"New Web Service Source\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
   testRunner.And("I type Address as \"http://RSAKLFSVRTFSBLD/IntegrationTestSite\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
   testRunner.And("I type Default Query as \"/GetCountries.ashx?extension=json&prefix=a\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
   testRunner.Then("\"New Web Service Source *\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
   testRunner.And("TestQuery is \"http://RSAKLFSVRTFSBLD/IntegrationTestSite/GetCountries.ashx?extens" +
                    "ion=json&prefix=a\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
   testRunner.And("\"Test Connection\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
   testRunner.And("\"Cancel Test\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
   testRunner.And("I Select Authentication Type as \"Anonymous\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
   testRunner.And("Username field is \"Collapsed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
   testRunner.And("Password field is \"Collapsed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
   testRunner.When("Test Connecton is \"Successful\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
   testRunner.When("I save as \"Testing Resource Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
   testRunner.Then("the save dialog is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
   testRunner.Then("title is \"Testing Resource Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
   testRunner.And("\"Testing Resource Save\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
   testRunner.When("I click TestQuery", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
   testRunner.Then("the browser window opens with \"http://RSAKLFSVRTFSBLD/IntegrationTestSite/GetCoun" +
                    "tries.ashx?extension=json&prefix=a\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Creating New Web Source under auth type as user")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        public virtual void CreatingNewWebSourceUnderAuthTypeAsUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating New Web Source under auth type as user", new string[] {
                        "WebSource"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
   testRunner.Given("I open New Web Source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
   testRunner.And("I type Address as \"http://RSAKLFSVRTFSBLD/IntegrationTestSite\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
   testRunner.And("I type Default Query as \"/GetCountries.ashx?extension=json&prefix=a\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
   testRunner.And("\"Test Connection\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
   testRunner.And("I Select Authentication Type as \"User\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
   testRunner.And("Username field is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
   testRunner.And("Password field is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
   testRunner.And("I type Username as \"IntegrationTester\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
   testRunner.And("I type Password as \"I73573r0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
   testRunner.When("Test Connecton is \"Successful\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
   testRunner.When("I save the source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
   testRunner.Then("the save dialog is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Incorrect address anonymous auth type not allowing save")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        public virtual void IncorrectAddressAnonymousAuthTypeNotAllowingSave()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incorrect address anonymous auth type not allowing save", new string[] {
                        "WebSource"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
   testRunner.Given("I open New Web Source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
   testRunner.And("I type Address as \"sdfsdfd\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
   testRunner.And("I type Default Query as \"/GetCountries.ashx?extension=json&prefix=a\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
   testRunner.And("\"Test Connection\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
   testRunner.And("I Select Authentication Type as \"Anonymous\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
   testRunner.When("Test Connecton is \"UnSuccessful\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
   testRunner.And("Validation message is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Incorrect address user auth type is not allowing to save")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        public virtual void IncorrectAddressUserAuthTypeIsNotAllowingToSave()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incorrect address user auth type is not allowing to save", new string[] {
                        "WebSource"});
#line 61
this.ScenarioSetup(scenarioInfo);
#line 62
   testRunner.Given("I open New Web Source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
   testRunner.And("I type Address as \"sdfsdfd\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
   testRunner.And("I type Default Query as \"/GetCountries.ashx?extension=json&prefix=a\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
   testRunner.And("\"Test Connection\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
   testRunner.And("I Select Authentication Type as \"User\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
   testRunner.And("I type Username as \"test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
   testRunner.And("I type Password as \"I73573r0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
   testRunner.When("Test Connecton is \"UnSuccessful\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
   testRunner.And("Validation message is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Testing Auth type as Anonymous and swaping it resets the test connection")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        public virtual void TestingAuthTypeAsAnonymousAndSwapingItResetsTheTestConnection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Testing Auth type as Anonymous and swaping it resets the test connection", new string[] {
                        "WebSource"});
#line 75
this.ScenarioSetup(scenarioInfo);
#line 76
   testRunner.Given("I open New Web Source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
   testRunner.And("\"Save\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
   testRunner.And("I type Address as \"http://RSAKLFSVRTFSBLD/IntegrationTestSite\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
   testRunner.And("I type Default Query as \"/GetCountries.ashx?extension=json&prefix=a\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
   testRunner.And("\"Test Connection\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
   testRunner.And("I Select Authentication Type as \"User\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
   testRunner.And("I type Username as \"test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
   testRunner.And("I type Password as \"I73573r0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
   testRunner.When("Test Connecton is \"Successful\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
   testRunner.And("Validation message is Not thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
   testRunner.And("I Select Authentication Type as \"Anonymous\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
   testRunner.And("Username field is \"Collapsed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
   testRunner.And("Password field is \"Collapsed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
   testRunner.When("Test Connecton is \"Successful\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
   testRunner.And("Validation message is Not thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
   testRunner.And("I Select Authentication Type as \"User\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
   testRunner.And("Username field is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
   testRunner.And("Password field is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing saved Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        public virtual void EditingSavedWebSource()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing saved Web Source", new string[] {
                        "WebSource"});
#line 101
this.ScenarioSetup(scenarioInfo);
#line 102
   testRunner.Given("I open \"Test\" web source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 103
   testRunner.Then("\"Test\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
   testRunner.And("title is \"Test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
   testRunner.And("Address is \"http://RSAKLFSVRTFSBLD/IntegrationTestSite\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
   testRunner.And("Default Query is \"/GetCountries.ashx?extension=json&prefix=a\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
   testRunner.And("\"Test Connection\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
   testRunner.And("Select Authentication Type as \"Anonymous\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
   testRunner.And("Username field is \"Collapsed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
   testRunner.And("Password field is \"Collapsed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
   testRunner.When("I change Address to \"http://RSAKLFSVRTFSBLD/IntegrationTestSite\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
   testRunner.And("I type Default Query as \"/GetCountries.ashx?extension=json&prefix=b\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
   testRunner.Then("\"Test *\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 116
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
   testRunner.And("\"Test Connection\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
   testRunner.When("Test Connecton is \"Successfull\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
   testRunner.Then("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
   testRunner.When("I save the source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing saved Web Source auth type")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        public virtual void EditingSavedWebSourceAuthType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing saved Web Source auth type", new string[] {
                        "WebSource"});
#line 124
 this.ScenarioSetup(scenarioInfo);
#line 125
   testRunner.Given("I open \"Test\" web source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 126
   testRunner.Then("\"Test\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
   testRunner.And("Address is \"http://RSAKLFSVRTFSBLD/IntegrationTestSite\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
   testRunner.And("Default Query is \"/GetCountries.ashx?extension=json&prefix=a\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
   testRunner.And("\"Test Connection\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
   testRunner.And("Select Authentication Type as \"Anonymous\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
   testRunner.And("Username field is \"Collapsed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
   testRunner.And("Password field is \"Collapsed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
   testRunner.When("I edit Authentication Type as \"User\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
   testRunner.And("Username field is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
   testRunner.And("Password field is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
   testRunner.And("Username field as \"IntegrationTester\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
   testRunner.And("Password field as \"I73573r0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
   testRunner.And("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
   testRunner.When("Test Connecton is \"Successfull\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
   testRunner.Then("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Cancel Seb Source Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        public virtual void CancelSebSourceTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancel Seb Source Test", new string[] {
                        "WebSource"});
#line 144
this.ScenarioSetup(scenarioInfo);
#line 145
   testRunner.Given("I open New Web Source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 146
   testRunner.Then("\"New Web Service Source\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
   testRunner.And("title is \"New Web Service Source\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
   testRunner.And("I type Address as \"http://test-warewolf.cloudapp.net:3142/public/Hello%20World?Na" +
                    "me=Me\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
   testRunner.When("Test Connecton is \"Long Running\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 150
   testRunner.And("I Cancel the Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
   testRunner.Then("\"Cancel Test\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 152
   testRunner.And("Validation message is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
   testRunner.And("Validation message is \"Test Cancelled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Web Source returns text")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Web Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WebSource")]
        public virtual void WebSourceReturnsText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Web Source returns text", ((string[])(null)));
#line 156
this.ScenarioSetup(scenarioInfo);
#line 157
   testRunner.Given("I open New Web Source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 158
   testRunner.Then("\"New Web Service Source\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 159
   testRunner.And("title is \"New Web Service Source\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
   testRunner.And("I type Address as \"http://warewolf.io/version.txt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
   testRunner.And("\"Test Connection\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
   testRunner.When("Test Connecton is \"Successful\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
   testRunner.Then("\"Save\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 164
   testRunner.When("I save as \"Testing Return Text\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 165
   testRunner.Then("the save dialog is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 166
   testRunner.Then("title is \"Testing Return Text\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 167
   testRunner.And("\"Testing Return Text\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion