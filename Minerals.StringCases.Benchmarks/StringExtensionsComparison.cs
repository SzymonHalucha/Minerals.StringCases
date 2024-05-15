namespace Minerals.StringCases.Benchmarks
{
    public class StringExtensionsComparison
    {
        private const string SampleText = "  _ example Variable - - Name   321";

        // Minerals.StringCases (https://www.nuget.org/packages/Minerals.StringCases/)
        [Benchmark]
        public void PascalCase_Minerals_StringCases()
        {
            string text = Minerals.StringCases.StringExtensions.ToPascalCase(SampleText);
        }

        [Benchmark]
        public void CamelCase_Minerals_StringCases()
        {
            string text = Minerals.StringCases.StringExtensions.ToCamelCase(SampleText);
        }

        [Benchmark]
        public void KebabCase_Minerals_StringCases()
        {
            string text = Minerals.StringCases.StringExtensions.ToKebabCase(SampleText);
        }

        [Benchmark]
        public void SnakeCase_Minerals_StringCases()
        {
            string text = Minerals.StringCases.StringExtensions.ToSnakeCase(SampleText);
        }

        [Benchmark]
        public void TrainCase_Minerals_StringCases()
        {
            string text = Minerals.StringCases.StringExtensions.ToTrainCase(SampleText);
        }

        // CaseExtensions (https://www.nuget.org/packages/CaseExtensions/)
        [Benchmark]
        public void PascalCase_CaseExtensions()
        {
            string text = CaseExtensions.StringExtensions.ToPascalCase(SampleText);
        }

        [Benchmark]
        public void CamelCase_CaseExtensions()
        {
            string text = CaseExtensions.StringExtensions.ToCamelCase(SampleText);
        }

        [Benchmark]
        public void KebabCase_CaseExtensions()
        {
            string text = CaseExtensions.StringExtensions.ToKebabCase(SampleText);
        }

        [Benchmark]
        public void SnakeCase_CaseExtensions()
        {
            string text = CaseExtensions.StringExtensions.ToSnakeCase(SampleText);
        }

        [Benchmark]
        public void TrainCase_CaseExtensions()
        {
            string text = CaseExtensions.StringExtensions.ToTrainCase(SampleText);
        }
    }
}