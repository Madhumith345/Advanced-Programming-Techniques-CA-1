// Unit test for Order class - testing pay_bill() method

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public sealed class TestOrder
{
    [TestMethod]
    public void Test_PayBill_SingleItem()
    {
        // Arrange
        Order order1 = new Order("Churros with plain sugar", 1, 6.00);

        // Act
        double bill = order1.pay_bill();

        // Assert
        Assert.AreEqual(6.00, bill);
    }

    [TestMethod]
    public void Test_PayBill_MultipleItems()
    {
        // Arrange
        Order order2 = new Order("Churros with chocolate sauce", 3, 8.00);

        // Act
        double bill = order2.pay_bill();

        // Assert
        Assert.AreEqual(24.00, bill);
    }

    [TestMethod]
    public void Test_PayBill_NutellaTwo()
    {
        // Arrange
        Order order3 = new Order("Churros with Nutella", 2, 8.00);

        // Act
        double bill = order3.pay_bill();

        // Assert
        Assert.AreEqual(16.00, bill);
    }

    [TestMethod]
    public void Test_PayBill_CinnamonSugarFive()
    {
        // Arrange
        Order order4 = new Order("Churros with cinnamon sugar", 5, 6.00);

        // Act
        double bill = order4.pay_bill();

        // Assert
        Assert.AreEqual(30.00, bill);
    }
}
