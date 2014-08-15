// Guids.cs
// MUST match guids.h
using System;

namespace TraceurLLC.RefactorableSettingsGenerator
{
    static class GuidList
    {
        public const string guidRefactorableSettingsGeneratorPkgString = "fc8167ea-ea1d-494c-bdef-25ecb997f8e8";
        public const string guidRefactorableSettingsGeneratorCmdSetString = "22b0cff5-c5ad-4a59-99cf-3db7e1fc7ccc";

        public const string guidRefactorableSettingsGeneratorString = "75a5a4c2-fa62-4a4f-8b90-829bdf802fa7";
        public static readonly Guid guidRefactorableSettingsGenerator = new Guid(guidRefactorableSettingsGeneratorString);

        public static readonly Guid guidRefactorableSettingsGeneratorCmdSet = new Guid(guidRefactorableSettingsGeneratorCmdSetString);
    };
}