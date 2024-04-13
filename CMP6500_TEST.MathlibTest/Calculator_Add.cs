using CMP6500_TEST.Mathlib;

namespace CMP6500_TEST.MathlibTest;

[TestClass]
public class Calculator_Add
{
    [TestMethod]
    public void Calculator_Add_Method_Receives_Two_Zeros_And_Returns_Zero()
    {
        Calculator calculator = new Calculator();
        var ret = calculator.Add(0, 0);
        Assert.AreEqual(0, ret);
    }

    [TestMethod]

    public void Calculator_Add_Method_Receives_Two_Positive_Numbers_And_Returns_Sum()
    {
       Calculator calculator = new Calculator();
        var ret = calculator.Add(1, 0);
        Assert.AreEqual(1, ret);
    }
}    