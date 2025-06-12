using Calculator;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CalculatorTests
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            TestEquation("1 + 2", 3);
            TestEquation("1 * 2", 2);
            TestEquation("1 - 2", -1);
            TestEquation("2 / 1", 2);
            TestEquation("1 + 2 * 3", 7);
            TestEquation("3 / 3 - 2", -1);
            TestEquation("10 / 5 * 2 + 1 - 4", 1);
            TestEquation("-3 + 3 / 1", 0);
        }
        public void TestEquation(string equation, double expect)
        {
            double res = Calculator.Program.result;
            Assert.Equal(expect,res);
        }
    }
}
