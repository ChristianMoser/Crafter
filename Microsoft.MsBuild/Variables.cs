using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafter.Microsoft.MsBuild
{
    public static class Environment
    {
        public const string BinPath = "$(MSBuildBinPath)";

        public const string ExtensionsPath = "$(MSBuildExtensionsPath)";

        public const string ExtensionsPath32 = "$(MSBuildExtensionsPath32)";

        public const string ExtensionsPath64 = "$(MSBuildExtensionsPath64)";

        public const string LastTaskResult = "$(MSBuildLastTaskResult)";
    }
}
