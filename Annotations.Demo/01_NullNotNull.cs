using System;
using JetBrains.Annotations;
using NUnit.Framework;

namespace Annotations.Demo
{
    [TestFixture]
    public class NullNotNull
    {
        [Test]
        public void NullReturnValue()
        {
            var canBeNull = NullDemo.CanReturnNull("param");
            Assert.IsTrue(canBeNull.Length > 0);
        }

        [Test]
        public void NullParameter()
        {
            var result = NullDemo.DoesNotAcceptNull("albumprinter") > 0;
            Assert.IsTrue(result);


            result = NullDemo.DoesNotAcceptNull(null) > 0;
            Assert.IsTrue(result);
        }
    }

    public class NullDemo
    {
        public static string CanReturnNull(string parameter)
        {
            var rand = new Random();
            return (rand.Next()%2) == 0 ? "string" : null;
        }

        public static int DoesNotAcceptNull(string parameter)
        {
            if (parameter == null) throw new ArgumentNullException("parameter");
            return parameter.Length;
        }
    }
}