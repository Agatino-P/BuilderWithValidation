using Builder;
using GalaSoft.MvvmLight.Ioc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTest40
{

    public class MockIIface:Mock<IIface>
    {
        public MockIIface()
        {

        Setup(
            mi => mi.Doppio(It.IsAny<int>())
                ).
                Returns((int i)=>triplo(i));

        }

        private int triplo(int i)
        {
            return i * 3;
        }

    }
    public class Tests
    {
        

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Buildable buildableOne = new Buildable.Builder().FromInt(1).Build();
            //Buildable buildableTwo = new Buildable(); //(Invalid, Private) 
            Buildable buildableTwo = new Buildable.Builder().Build();
            Buildable buildableThree = new Buildable.Builder().FromInt(3).Build();
            Assert.AreEqual(buildableOne.Testo, "Uno");
            Assert.IsNull(buildableThree);

            
            SimpleIoc.Default.Register<IIface>(()=> new MockIIface().Object);
            
            IocConsumer iocConsumer = new IocConsumer();
            int b = iocConsumer.D(1);
            //Assert.AreEqual(mock.Object.Doppio(1), 2);

            //Assert.Pass();
        }
    }
}
