using System;
using System.Diagnostics;
using JetBrains.Annotations;
using NUnit.Framework;

namespace Annotations.Demo
{
    [TestFixture]
    public class StringFormatDemo
    {
        [Test]
        public void Test()
        {
            DemoLoger.PrintMessage("hello world. It's {0} now {33}", DateTime.Now, 12);
        }
    }

    
    public static class DemoLoger
    {
//        [StringFormatMethod("formatTemplate")]
        public static void PrintMessage(string formatTemplate, params object[] args)
        {
            Debug.WriteLine(formatTemplate, args);
        }
    }
}