using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var subscription = new Subscription(null);
        var student = new Student("Ramon", "Ramos", "123.123.123-33", "ramonramos.silva19@gmail.com");
        student.AddSubscription(subscription);
    }
}