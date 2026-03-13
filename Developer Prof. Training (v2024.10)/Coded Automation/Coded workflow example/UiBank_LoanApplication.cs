using Codedworkflowexample.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Codedworkflowexample
{
    public class UiBank_LoanApplication : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            CheckStateOptions checkStateOpts = new CheckStateOptions
            {
                CheckVisibility = true,
                Mode = NCheckStateMode.WaitAppear
            };
            
            var HomeScreen = uiAutomation.Open("Home");
            HomeScreen.Click("Apply For Loan");
            var loanScreen = uiAutomation.Attach("LoanScreen");
            loanScreen.Click("Apply For A Loan");
            
            var loanApplicationScreen = uiAutomation.Attach("LoanApplicationScreen");
            loanApplicationScreen.TypeInto("Email Address","john@example.com");
            loanApplicationScreen.TypeInto("Loan Amount Requested","12000");
            loanApplicationScreen.SelectItem("Loan Term","10");
            loanApplicationScreen.TypeInto("Current Yearly Income","1200");
            loanApplicationScreen.TypeInto("Age","28");
            loanApplicationScreen.Click("Submit Loan Application");
         
            var loanStatusScreen = uiAutomation.Attach("LoanStatusScreen");
            bool isLoanApproved = loanStatusScreen.WaitState("Loan Approved Label",checkStateOpts);

            if (isLoanApproved) {
                Log("The loan was approved");
            } else {
                Log("The loan was not approved");
            }
        }
    }
}