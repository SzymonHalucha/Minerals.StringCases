namespace Minerals.StringCases
{
    public static class StringExtensions
    {
        public static string ToPascalCase(this string value)
        {
            int newIndex = 0;
            bool separator = true;
            UnicodeCategory current;
            char[] newString = new char[value.Length + CalculateSpanSizeForPascalOrCamelCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                current = char.GetUnicodeCategory(value[i]);
                separator = (current != UnicodeCategory.LowercaseLetter && current != UnicodeCategory.DecimalDigitNumber) || separator;
                if (IsSpecialCharacter(current) is false)
                {
                    newString[newIndex] = separator ? char.ToUpperInvariant(value[i]) : char.ToLowerInvariant(value[i]);
                    separator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToCamelCase(this string value)
        {
            int newIndex = 0;
            bool separator = false;
            bool firstCharacter = true;
            UnicodeCategory current;
            char[] newString = new char[value.Length + CalculateSpanSizeForPascalOrCamelCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                current = char.GetUnicodeCategory(value[i]);
                separator = (current != UnicodeCategory.LowercaseLetter && current != UnicodeCategory.DecimalDigitNumber) || separator;
                if (IsSpecialCharacter(current) is false)
                {
                    newString[newIndex] = separator && firstCharacter is false
                        ? char.ToUpperInvariant(value[i])
                        : char.ToLowerInvariant(value[i]);
                    firstCharacter = false;
                    separator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToUnderscoreCamelCase(this string value)
        {
            int newIndex = 1;
            bool separator = false;
            bool firstCharacter = true;
            UnicodeCategory current;
            char[] newString = new char[value.Length + CalculateSpanSizeForPascalOrCamelCase(value) + 1];
            newString[0] = '_';
            for (int i = 1; i < value.Length; i++)
            {
                current = char.GetUnicodeCategory(value[i]);
                separator = (current != UnicodeCategory.LowercaseLetter && current != UnicodeCategory.DecimalDigitNumber) || separator;
                if (IsSpecialCharacter(current) is false)
                {
                    newString[newIndex] = separator && firstCharacter is false
                        ? char.ToUpperInvariant(value[i])
                        : char.ToLowerInvariant(value[i]);
                    firstCharacter = false;
                    separator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToKebabCase(this string value)
        {
            int newIndex = 0;
            bool separator = true;
            bool firstCharacter = true;
            UnicodeCategory current;
            char[] newString = new char[value.Length + CalculateSpanSizeForKebabOrSnakeCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                current = char.GetUnicodeCategory(value[i]);
                separator = (current != UnicodeCategory.LowercaseLetter && current != UnicodeCategory.DecimalDigitNumber) || separator;
                if (IsSpecialCharacter(current) is false)
                {
                    if (separator && firstCharacter is false)
                    {
                        newString[newIndex] = '-';
                        newIndex++;
                    }
                    newString[newIndex] = char.ToLowerInvariant(value[i]);
                    firstCharacter = false;
                    separator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToSnakeCase(this string value)
        {
            int newIndex = 0;
            bool separator = true;
            bool firstCharacter = true;
            UnicodeCategory current;
            char[] newString = new char[value.Length + CalculateSpanSizeForKebabOrSnakeCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                current = char.GetUnicodeCategory(value[i]);
                separator = (current != UnicodeCategory.LowercaseLetter && current != UnicodeCategory.DecimalDigitNumber) || separator;
                if (IsSpecialCharacter(current) is false)
                {
                    if (separator && firstCharacter is false)
                    {
                        newString[newIndex] = '_';
                        newIndex++;
                    }
                    newString[newIndex] = char.ToLowerInvariant(value[i]);
                    firstCharacter = false;
                    separator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToMacroCase(this string value)
        {
            int newIndex = 0;
            bool separator = true;
            bool firstCharacter = true;
            UnicodeCategory current;
            char[] newString = new char[value.Length + CalculateSpanSizeForKebabOrSnakeCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                current = char.GetUnicodeCategory(value[i]);
                separator = (current != UnicodeCategory.LowercaseLetter && current != UnicodeCategory.DecimalDigitNumber) || separator;
                if (IsSpecialCharacter(current) is false)
                {
                    if (separator && firstCharacter is false)
                    {
                        newString[newIndex] = '_';
                        newIndex++;
                    }
                    newString[newIndex] = char.ToUpperInvariant(value[i]);
                    firstCharacter = false;
                    separator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToTrainCase(this string value)
        {
            int newIndex = 0;
            bool separator = true;
            bool firstCharacter = true;
            UnicodeCategory current;
            char[] newString = new char[value.Length + CalculateSpanSizeForKebabOrSnakeCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                current = char.GetUnicodeCategory(value[i]);
                separator = (current != UnicodeCategory.LowercaseLetter && current != UnicodeCategory.DecimalDigitNumber) || separator;
                if (IsSpecialCharacter(current) is false)
                {
                    if (separator && firstCharacter is false)
                    {
                        newString[newIndex] = '-';
                        newIndex++;
                    }
                    newString[newIndex] = separator
                        ? char.ToUpperInvariant(value[i])
                        : char.ToLowerInvariant(value[i]);
                    firstCharacter = false;
                    separator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToTitleCase(this string value)
        {
            int newIndex = 0;
            bool separator = true;
            bool firstCharacter = true;
            UnicodeCategory current;
            char[] newString = new char[value.Length + CalculateSpanSizeForKebabOrSnakeCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                current = char.GetUnicodeCategory(value[i]);
                separator = (current != UnicodeCategory.LowercaseLetter && current != UnicodeCategory.DecimalDigitNumber) || separator;
                if (IsSpecialCharacter(current) is false)
                {
                    if (separator && firstCharacter is false)
                    {
                        newString[newIndex] = ' ';
                        newIndex++;
                    }
                    newString[newIndex] = separator
                        ? char.ToUpperInvariant(value[i])
                        : char.ToLowerInvariant(value[i]);
                    firstCharacter = false;
                    separator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int CalculateSpanSizeForKebabOrSnakeCase(string text)
        {
            UnicodeCategory previous = char.GetUnicodeCategory(text[0]);
            UnicodeCategory current;
            int divs = IsSpecialCharacter(previous) ? -1 : 0;
            int skips = IsSpecialCharacter(previous) ? 1 : 0;
            for (int i = 1; i < text.Length - 2; i++)
            {
                current = char.GetUnicodeCategory(text[i]);
                skips += IsSpecialCharacter(current) ? 1 : 0;
                divs += (current == UnicodeCategory.UppercaseLetter && previous != UnicodeCategory.UppercaseLetter)
                    || (current == UnicodeCategory.DecimalDigitNumber && previous != UnicodeCategory.DecimalDigitNumber)
                    || (current == UnicodeCategory.LowercaseLetter && previous != UnicodeCategory.LowercaseLetter && previous != UnicodeCategory.UppercaseLetter) ? 1 : 0;
                previous = current;
            }
            return divs - skips;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int CalculateSpanSizeForPascalOrCamelCase(string text)
        {
            UnicodeCategory current;
            int skips = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                current = char.GetUnicodeCategory(text[i]);
                skips -= IsSpecialCharacter(current) ? 1 : 0;
            }
            return skips;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsSpecialCharacter(UnicodeCategory category)
        {
            return category != UnicodeCategory.UppercaseLetter
                && category != UnicodeCategory.LowercaseLetter
                && category != UnicodeCategory.DecimalDigitNumber;
        }
    }
}