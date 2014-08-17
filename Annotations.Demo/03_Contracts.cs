using System.Linq;
using NUnit.Framework;

namespace Annotations.Demo
{
    [TestFixture]
    public class Contracts
    {
        [Test]
        public void Test()
        {
            var str = ContractTest.Reverse(null);
            Assert.AreEqual("", str.Length);

            var reverse = ContractTest.Reverse("haha");
            if (reverse == null)
            {
                // never goes here
            }
            Assert.AreEqual("ahah", reverse);
        }
    }


    public static class ContractTest
    {
//        [ContractAnnotation("str:null => null;str:notnull=>notnull")]
        public static string Reverse(string str)
        {
            if (str == null) return null;
            return new string(str.Reverse().ToArray());
        }
    }
}