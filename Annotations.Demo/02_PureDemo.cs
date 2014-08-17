﻿using NUnit.Framework;

namespace Annotations.Demo
{
    [TestFixture]
    public class PureDemo
    {
        [Test]
        public void PureDemoTest()
        {
            var myInt = new MyInt(10);
            Assert.AreEqual(10, myInt.Value);



            myInt.Add(20);
            Assert.AreEqual(30, myInt.Value);
        }
    }


    public class MyInt
    {
        private readonly int value;

        public MyInt(int value)
        {
            this.value = value;
        }

        public int Value
        {
            get { return value; }
        }

        public MyInt Add(int add)
        {
            return new MyInt(Value + add);
        }
    }
}