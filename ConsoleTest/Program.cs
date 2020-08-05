using System;
using CSharpTest;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharpTest.WorkDayCalculatorTests tests = new WorkDayCalculatorTests();
            tests.TestNoWeekEnd();
            tests.TestNormalPath();
            tests.TestNormalPathMultiplyWeekends();
            tests.TestWeekendAfterEnd();
        }
    }
}
