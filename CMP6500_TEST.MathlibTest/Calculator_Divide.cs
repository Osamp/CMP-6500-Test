using CMP6500_TEST.Mathlib;

namespace CMP6500_TEST.MathlibTest;

[TestClass]
public class Calculator_Divide
{
    public void Calculator_Divide_Method_Receives_A_Number_And_One_Then_Returns_Number()
    {
        Calculator calculator = new Calculator();
        var ret = calculator.Divide (4, 1);
        Assert.AreEqual(4, ret);
    }


    [TestMethod]
    [DataRow(1.0, 1.0, 1.0)]
    [DataRow(2.0, 2.0, 1.0)]
    public void Calculator_Divide_Method_Receives_Two_Of_The_Same_Number_Then_Returns_One(double left, double right, double expected)
    {
        Calculator calculator= new Calculator();
        var ret = calculator.Divide((decimal)left, (decimal)right);
        Assert.AreEqual((decimal)expected,ret);
    }


    [TestMethod]
     public void Calculator_Divide_Method_Receives_A_Number_And_Zero_Then_Returns_Exception()
    {
        Calculator calculator = new Calculator();
        var ret = calculator.Divide (4, 1);
        Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(4,0));
    }
}    