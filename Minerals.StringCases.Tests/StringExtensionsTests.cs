namespace Minerals.StringCases.Tests
{
    [TestClass]
    public class StringExtensionsTest
    {
        private const string PascalCase = "ExampleVariableName321";
        private const string CamelCase = "exampleVariableName321";
        private const string UnderscoreCamelCase = "_exampleVariableName321";
        private const string KebabCase = "example-variable-name-321";
        private const string SnakeCase = "example_variable_name_321";
        private const string TrainCase = "Example-Variable-Name-321";
        private const string TitleCase = "Example Variable Name 321";
        private const string SampleText = "  _ example Variable - - Name   321";

        [TestMethod]
        public void PascalCase_FromSampleText()
        {
            Minerals.StringCases.StringExtensions.ToPascalCase(SampleText).Should().Be(PascalCase);
        }

        [TestMethod]
        public void CamelCase_FromSampleText()
        {
            Minerals.StringCases.StringExtensions.ToCamelCase(SampleText).Should().Be(CamelCase);
        }

        [TestMethod]
        public void UnderscoreCamelCase_FromSampleText()
        {
            Minerals.StringCases.StringExtensions.ToUnderscoreCamelCase(SampleText).Should().Be(UnderscoreCamelCase);
        }

        [TestMethod]
        public void KebabCase_FromSampleText()
        {
            Minerals.StringCases.StringExtensions.ToKebabCase(SampleText).Should().Be(KebabCase);
        }

        [TestMethod]
        public void SnakeCase_FromSampleText()
        {
            Minerals.StringCases.StringExtensions.ToSnakeCase(SampleText).Should().Be(SnakeCase);
        }

        [TestMethod]
        public void TrainCase_FromSampleText()
        {
            Minerals.StringCases.StringExtensions.ToTrainCase(SampleText).Should().Be(TrainCase);
        }

        [TestMethod]
        public void TitleCase_FromSampleText()
        {
            Minerals.StringCases.StringExtensions.ToTitleCase(SampleText).Should().Be(TitleCase);
        }
    }
}