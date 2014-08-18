using JetBrains.Annotations;
using NUnit.Framework;

namespace Annotations.Demo
{
    [TestFixture]
    public class PureDemo
    {
        [Test]
        public void PureDemoTestSuccess()
        {
            var myInt = new MyInt(10);
            Assert.AreEqual(10, myInt.Value);
        }

        [Test]
        public void PureDemoTestFail()
        {
            var myInt = new MyInt(10);
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