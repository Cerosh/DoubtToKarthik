using NUnit.Framework;
using CSharpAutomationFrameworkLearningLevel7.Base;

namespace EAEmployeeTestLevel7
{
    
    public class Tests : HookInitialize
    {
        
        
        [Test]
        public void Test1()
        {
            System.Console.WriteLine("*****Test Case Level 7*****");
        }
        [TearDown]
        public void TestTearDown()
        {
            DriverContext.Driver.Quit();
        }
    }
}