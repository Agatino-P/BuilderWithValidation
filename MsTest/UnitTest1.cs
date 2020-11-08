using System;
using Builder;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MsTest
{

    public class MockIIface : Mock<IIface>
    {
        public MockIIface()
        {

            Setup(
                mi => mi.Doppio(It.IsAny<int>())
                    ).
                    Returns((int i) => triplo(i));

        }

        private int triplo(int i)
        {
            return i * 3;
        }

    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            SimpleIoc.Default.Register<IIface>(() => new MockIIface().Object);

            IocConsumer iocConsumer = new IocConsumer();
            int b = iocConsumer.D(1);
        }
    }
}
