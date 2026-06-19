using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class Tests
    {
        Mock<IMailSender> mockMailSender;
        CustomerCommLib.CustomerComm customerComm ;

        [OneTimeSetUp]
        public void Setup()
        {
            mockMailSender = new Mock<IMailSender>();

            mockMailSender
                .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            customerComm = new CustomerCommLib.CustomerComm(mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomer_Test()
        {
            bool result = customerComm.SendMailToCustomer();

            Assert.That(result, Is.True);
        }
    }
}