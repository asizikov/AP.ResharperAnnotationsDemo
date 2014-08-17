using JetBrains.Annotations;
using NUnit.Framework;

namespace Annotations.Demo
{
    [TestFixture]
    public class ResourceNavigation
    {
        [Test]
        public void Evaluate()
        {
            PathHelper.SomeMethod("/04_PublicApi.cs");  //ctrl+click navigation works, wow ;)
        }
    }

    public static class PathHelper
    {
        public static bool SomeMethod([PathReference] string path)
        {
            return false;
        }
    }
}