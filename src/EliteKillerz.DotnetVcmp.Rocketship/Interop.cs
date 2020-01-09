using System;
using EliteKillerz.DotnetVcmp.RuntimeClient;
using EliteKillerz.DotnetVcmp.RuntimeClient.VcmpSdk;

namespace EliteKillerz.DotnetVcmp.Rocketship
{
    public static partial class Interop
    {
        [UserEntryPoint]
        public static void EntryPoint(PluginFunctions pluginFunctions, ref PluginEvents pluginEvents)
        {
            _sdkFunctions = pluginFunctions;
            BindEvents(ref pluginEvents);
        }

        internal static PluginFunctions SdkFunctions
        {
            get
            {
                if (_sdkFunctions == null)
                    throw new NullReferenceException();

                return _sdkFunctions;
            }
        }

        private static PluginFunctions? _sdkFunctions;
    }
}
