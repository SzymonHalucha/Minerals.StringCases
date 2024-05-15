namespace Minerals.StringCases.Benchmarks
{
    public class StringExtensionsBenchmarks
    {
        private const string SampleText = "  _ example Variable - - Name   321";

        [Benchmark]
        public void PascalCase_FromSampleText()
        {
            string text = Minerals.StringCases.StringExtensions.ToPascalCase(SampleText);
        }

        [Benchmark]
        public void CamelCase_FromSampleText()
        {
            string text = Minerals.StringCases.StringExtensions.ToCamelCase(SampleText);
        }

        [Benchmark]
        public void UnderscoreCamelCase_FromSampleText()
        {
            string text = Minerals.StringCases.StringExtensions.ToUnderscoreCamelCase(SampleText);
        }

        [Benchmark]
        public void KebabCase_FromSampleText()
        {
            string text = Minerals.StringCases.StringExtensions.ToKebabCase(SampleText);
        }

        [Benchmark]
        public void SnakeCase_FromSampleText()
        {
            string text = Minerals.StringCases.StringExtensions.ToSnakeCase(SampleText);
        }

        [Benchmark]
        public void MacroCase_FromSampleText()
        {
            string text = Minerals.StringCases.StringExtensions.ToMacroCase(SampleText);
        }

        [Benchmark]
        public void TrainCase_FromSampleText()
        {
            string text = Minerals.StringCases.StringExtensions.ToTrainCase(SampleText);
        }

        [Benchmark]
        public void TitleCase_FromSampleText()
        {
            string text = Minerals.StringCases.StringExtensions.ToTitleCase(SampleText);
        }
    }
}