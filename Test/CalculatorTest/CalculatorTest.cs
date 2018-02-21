using System;
using Service;
using Xunit;

namespace XUnitTestProject1
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
          var cal = new Calculator();
          var actual = cal.Add(1, 2);

          Assert.Equal(3, actual);
        }
    }
}
