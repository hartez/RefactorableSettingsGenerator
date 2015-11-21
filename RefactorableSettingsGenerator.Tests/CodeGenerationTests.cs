using System.IO;
using NUnit.Framework;
using CodeWiseLLC.RefactorableSettingsGenerator;

namespace RefactorableSettingsGenerator.Tests
{
    [TestFixture]
    public class CodeGenerationTests
    {
        [Test]
        public void GeneratedCodeMatchesTarget()
        {
            var targetText = File.ReadAllText("Settings.cs.txt");

            var code = SettingsCodeGenerator.GenerateCodeFrom("Settings.settings");

            code.ShouldEqualWithDiff(targetText);
        }
    }

    public enum DiffStyle
    {
        Full,
        Minimal
    }
}