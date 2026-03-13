using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Codedworkflowexample.ObjectRepository
{
    public static class Descriptors
    {
        public static class UiBank
        {
            static string _reference = "lFtPYlJpW02_XJipta_B6g/HFnpWCoFKUCWF4mbV2yJ5A";
            public static _Implementation._UiBank.__Home Home { get; private set; } = new _Implementation._UiBank.__Home();
            public static _Implementation._UiBank.__LoanApplicationScreen LoanApplicationScreen { get; private set; } = new _Implementation._UiBank.__LoanApplicationScreen();
            public static _Implementation._UiBank.__LoanScreen LoanScreen { get; private set; } = new _Implementation._UiBank.__LoanScreen();
            public static _Implementation._UiBank.__LoanStatusScreen LoanStatusScreen { get; private set; } = new _Implementation._UiBank.__LoanStatusScreen();
        }
    }
}

namespace Codedworkflowexample._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _UiBank._Home
    {
        public class __Apply_For_Loan : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Apply_For_Loan(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/Cj6XpUS5PEehiVSmr7U-KQ", DisplayName = "Apply For Loan", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank
    {
        public class __Home : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Home()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/fO1BriDal0etlLrlFWu3IA", DisplayName = "Home", Screen = this};
                Apply_For_Loan = new _Implementation._UiBank._Home.__Apply_For_Loan(this, null);
            }

            public _Implementation._UiBank._Home.__Apply_For_Loan Apply_For_Loan { get; private set; }
        }
    }

    namespace _UiBank._LoanApplicationScreen
    {
        public class __Age : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Age(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/WG3kNXJoPkWsyTgenIJ3Yw", DisplayName = "Age", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank._LoanApplicationScreen
    {
        public class __Current_Yearly_Income : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Current_Yearly_Income(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/31I0HNhbA026v-BJRNxL3Q", DisplayName = "Current Yearly Income", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank._LoanApplicationScreen
    {
        public class __Email_Address : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Email_Address(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/9bAjrAW7ck-YsPVsEA-DJA", DisplayName = "Email Address", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank._LoanApplicationScreen
    {
        public class __Loan_Amount_Requested : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Amount_Requested(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/J0alhW5BEUiRPXNDZAUmRA", DisplayName = "Loan Amount Requested", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank._LoanApplicationScreen
    {
        public class __Loan_Term : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Term(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/JcyQ2JMgLUCgq9SdF3eymg", DisplayName = "Loan Term", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank._LoanApplicationScreen
    {
        public class __Submit_Loan_Application : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Submit_Loan_Application(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/VeRVlq2aE0iMhEuY32ucIg", DisplayName = "Submit Loan Application", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank
    {
        public class __LoanApplicationScreen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __LoanApplicationScreen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/0h-MxVjZbUudWqsiKBy0dg", DisplayName = "LoanApplicationScreen", Screen = this};
                Age = new _Implementation._UiBank._LoanApplicationScreen.__Age(this, null);
                Current_Yearly_Income = new _Implementation._UiBank._LoanApplicationScreen.__Current_Yearly_Income(this, null);
                Email_Address = new _Implementation._UiBank._LoanApplicationScreen.__Email_Address(this, null);
                Loan_Amount_Requested = new _Implementation._UiBank._LoanApplicationScreen.__Loan_Amount_Requested(this, null);
                Loan_Term = new _Implementation._UiBank._LoanApplicationScreen.__Loan_Term(this, null);
                Submit_Loan_Application = new _Implementation._UiBank._LoanApplicationScreen.__Submit_Loan_Application(this, null);
            }

            public _Implementation._UiBank._LoanApplicationScreen.__Age Age { get; private set; }

            public _Implementation._UiBank._LoanApplicationScreen.__Current_Yearly_Income Current_Yearly_Income { get; private set; }

            public _Implementation._UiBank._LoanApplicationScreen.__Email_Address Email_Address { get; private set; }

            public _Implementation._UiBank._LoanApplicationScreen.__Loan_Amount_Requested Loan_Amount_Requested { get; private set; }

            public _Implementation._UiBank._LoanApplicationScreen.__Loan_Term Loan_Term { get; private set; }

            public _Implementation._UiBank._LoanApplicationScreen.__Submit_Loan_Application Submit_Loan_Application { get; private set; }
        }
    }

    namespace _UiBank._LoanScreen
    {
        public class __Apply_For_A_Loan : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Apply_For_A_Loan(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/6Tq7odPorEChXRuJ3EdhVw", DisplayName = "Apply For A Loan", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank
    {
        public class __LoanScreen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __LoanScreen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/SYcMWZneWkyt5TPlwwQzlA", DisplayName = "LoanScreen", Screen = this};
                Apply_For_A_Loan = new _Implementation._UiBank._LoanScreen.__Apply_For_A_Loan(this, null);
            }

            public _Implementation._UiBank._LoanScreen.__Apply_For_A_Loan Apply_For_A_Loan { get; private set; }
        }
    }

    namespace _UiBank._LoanStatusScreen
    {
        public class __APR : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __APR(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/ckXuZZNlaUm7sY4eBuQ4-A", DisplayName = "APR", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank._LoanStatusScreen
    {
        public class __Loan_Approved_Label : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Approved_Label(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/msWbVa9TYUOuWlPtUAK5DA", DisplayName = "Loan Approved Label", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank._LoanStatusScreen
    {
        public class __Loan_Id : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Id(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/7yuwOVgTK0mkzkbzQE2HMQ", DisplayName = "Loan Id", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank
    {
        public class __LoanStatusScreen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __LoanStatusScreen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "lFtPYlJpW02_XJipta_B6g/nvt-buVH6EWsRp3rHPFxxw", DisplayName = "LoanStatusScreen", Screen = this};
                APR = new _Implementation._UiBank._LoanStatusScreen.__APR(this, null);
                Loan_Approved_Label = new _Implementation._UiBank._LoanStatusScreen.__Loan_Approved_Label(this, null);
                Loan_Id = new _Implementation._UiBank._LoanStatusScreen.__Loan_Id(this, null);
            }

            public _Implementation._UiBank._LoanStatusScreen.__APR APR { get; private set; }

            public _Implementation._UiBank._LoanStatusScreen.__Loan_Approved_Label Loan_Approved_Label { get; private set; }

            public _Implementation._UiBank._LoanStatusScreen.__Loan_Id Loan_Id { get; private set; }
        }
    }
}