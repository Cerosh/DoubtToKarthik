using CSharpAutomationFrameworkLearningLevel7.Base;
using static CSharpAutomationFrameworkLearningLevel7.Base.Browser;

namespace EAEmployeeTestLevel7
{
    public class HookInitialize : TestInitializeHook
    {

        public HookInitialize() : base(BrowserType.Chrome)
        {

            InitializeSettings();
            NavigateSite();
        }
        
    }
}
