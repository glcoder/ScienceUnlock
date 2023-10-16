using System.Reflection;

namespace ScienceUnlock
{
    internal static class Main
    {
        [OnGameAssemblyLoad]
        public static void OnGameAssemblyLoad(Assembly assembly)
        {
            if (!BuildInfo.isDemo)
                return;

            BuildInfo.isDemo = false;
        }
    }
}
