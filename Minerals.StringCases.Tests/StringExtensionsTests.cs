namespace Minerals.StringCases.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        private const string PascalCase1 = "ExampleVariableName321TestA";
        private const string CamelCase1 = "exampleVariableName321TestA";
        private const string UnderscoreCamelCase1 = "_exampleVariableName321TestA";
        private const string KebabCase1 = "example-variable-name-321-test-a";
        private const string SnakeCase1 = "example_variable_name_321_test_a";
        private const string MacroCase1 = "EXAMPLE_VARIABLE_NAME_321_TEST_A";
        private const string TrainCase1 = "Example-Variable-Name-321-Test-A";
        private const string TitleCase1 = "Example Variable Name 321 Test A";
        private const string SampleText1 = "  _ example Variable - - Name   321 TestA";

        [TestMethod]
        public void PascalCase_FromSampleText1()
        {
            Minerals.StringCases.StringExtensions.ToPascalCase(SampleText1).Should().Be(PascalCase1);
        }

        [TestMethod]
        public void CamelCase_FromSampleText1()
        {
            Minerals.StringCases.StringExtensions.ToCamelCase(SampleText1).Should().Be(CamelCase1);
        }

        [TestMethod]
        public void UnderscoreCamelCase_FromSampleText1()
        {
            Minerals.StringCases.StringExtensions.ToUnderscoreCamelCase(SampleText1).Should().Be(UnderscoreCamelCase1);
        }

        [TestMethod]
        public void KebabCase_FromSampleText1()
        {
            Minerals.StringCases.StringExtensions.ToKebabCase(SampleText1).Should().Be(KebabCase1);
        }

        [TestMethod]
        public void SnakeCase_FromSampleText1()
        {
            Minerals.StringCases.StringExtensions.ToSnakeCase(SampleText1).Should().Be(SnakeCase1);
        }

        [TestMethod]
        public void MacroCase_FromSampleText1()
        {
            Minerals.StringCases.StringExtensions.ToMacroCase(SampleText1).Should().Be(MacroCase1);
        }

        [TestMethod]
        public void TrainCase_FromSampleText1()
        {
            Minerals.StringCases.StringExtensions.ToTrainCase(SampleText1).Should().Be(TrainCase1);
        }

        [TestMethod]
        public void TitleCase_FromSampleText1()
        {
            Minerals.StringCases.StringExtensions.ToTitleCase(SampleText1).Should().Be(TitleCase1);
        }

        private const string PascalCase2 = "ExampleVariableNameAbCd321";
        private const string CamelCase2 = "exampleVariableNameAbCd321";
        private const string UnderscoreCamelCase2 = "_exampleVariableNameAbCd321";
        private const string KebabCase2 = "example-variable-name-ab-cd-321";
        private const string SnakeCase2 = "example_variable_name_ab_cd_321";
        private const string MacroCase2 = "EXAMPLE_VARIABLE_NAME_AB_CD_321";
        private const string TrainCase2 = "Example-Variable-Name-Ab-Cd-321";
        private const string TitleCase2 = "Example Variable Name Ab Cd 321";
        private const string SampleText2 = "  _ example VARIABLE - - Name AbCd   321";

        [TestMethod]
        public void PascalCase_FromSampleText2()
        {
            Minerals.StringCases.StringExtensions.ToPascalCase(SampleText2).Should().Be(PascalCase2);
        }

        [TestMethod]
        public void CamelCase_FromSampleText2()
        {
            Minerals.StringCases.StringExtensions.ToCamelCase(SampleText2).Should().Be(CamelCase2);
        }

        [TestMethod]
        public void UnderscoreCamelCase_FromSampleText2()
        {
            Minerals.StringCases.StringExtensions.ToUnderscoreCamelCase(SampleText2).Should().Be(UnderscoreCamelCase2);
        }

        [TestMethod]
        public void KebabCase_FromSampleText2()
        {
            Minerals.StringCases.StringExtensions.ToKebabCase(SampleText2).Should().Be(KebabCase2);
        }

        [TestMethod]
        public void SnakeCase_FromSampleText2()
        {
            Minerals.StringCases.StringExtensions.ToSnakeCase(SampleText2).Should().Be(SnakeCase2);
        }

        [TestMethod]
        public void MacroCase_FromSampleText2()
        {
            Minerals.StringCases.StringExtensions.ToMacroCase(SampleText2).Should().Be(MacroCase2);
        }

        [TestMethod]
        public void TrainCase_FromSampleText2()
        {
            Minerals.StringCases.StringExtensions.ToTrainCase(SampleText2).Should().Be(TrainCase2);
        }

        [TestMethod]
        public void TitleCase_FromSampleText2()
        {
            Minerals.StringCases.StringExtensions.ToTitleCase(SampleText2).Should().Be(TitleCase2);
        }
    }
}