namespace Minerals.StringCases
{
    public static class StringExtensions
    {
        public static string ToPascalCase(this string value)
        {
            int newIndex = 0;
            bool insertSeparator = true;
            UnicodeCategory previous;
            UnicodeCategory current = UnicodeCategory.OtherSymbol;
            char[] newString = new char[value.Length + CalculateSpanSizeForPascalOrCamelCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                previous = current;
                current = char.GetUnicodeCategory(value[i]);
                insertSeparator = (previous != current && (current is UnicodeCategory.UppercaseLetter || current is UnicodeCategory.DecimalDigitNumber)) || insertSeparator;
                if (!IsSpecialCharacter(current))
                {
                    newString[newIndex] = insertSeparator
                        ? char.ToUpperInvariant(value[i])
                        : char.ToLowerInvariant(value[i]);
                    insertSeparator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToCamelCase(this string value)
        {
            int newIndex = 0;
            bool insertSeparator = false;
            bool isFirstCharacter = true;
            UnicodeCategory previous;
            UnicodeCategory current = UnicodeCategory.OtherSymbol;
            char[] newString = new char[value.Length + CalculateSpanSizeForPascalOrCamelCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                previous = current;
                current = char.GetUnicodeCategory(value[i]);
                insertSeparator = (previous != current && (current is UnicodeCategory.UppercaseLetter || current is UnicodeCategory.DecimalDigitNumber)) || insertSeparator;
                if (!IsSpecialCharacter(current))
                {
                    newString[newIndex] = insertSeparator && !isFirstCharacter
                        ? char.ToUpperInvariant(value[i])
                        : char.ToLowerInvariant(value[i]);
                    isFirstCharacter = false;
                    insertSeparator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToUnderscoreCamelCase(this string value)
        {
            int newIndex = 1;
            bool insertSeparator = false;
            bool isFirstCharacter = true;
            UnicodeCategory previous;
            UnicodeCategory current = UnicodeCategory.OtherSymbol;
            char[] newString = new char[value.Length + CalculateSpanSizeForPascalOrCamelCase(value) + 1];
            newString[0] = '_';
            for (int i = 1; i < value.Length; i++)
            {
                previous = current;
                current = char.GetUnicodeCategory(value[i]);
                insertSeparator = (previous != current && (current is UnicodeCategory.UppercaseLetter || current is UnicodeCategory.DecimalDigitNumber)) || insertSeparator;
                if (!IsSpecialCharacter(current))
                {
                    newString[newIndex] = insertSeparator && !isFirstCharacter
                        ? char.ToUpperInvariant(value[i])
                        : char.ToLowerInvariant(value[i]);
                    isFirstCharacter = false;
                    insertSeparator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToKebabCase(this string value)
        {
            int newIndex = 0;
            bool insertSeparator = true;
            bool isFirstCharacter = true;
            UnicodeCategory previous;
            UnicodeCategory current = UnicodeCategory.OtherSymbol;
            char[] newString = new char[value.Length + CalculateSpanSizeForKebabOrSnakeCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                previous = current;
                current = char.GetUnicodeCategory(value[i]);
                insertSeparator = (previous != current && (current is UnicodeCategory.UppercaseLetter || current is UnicodeCategory.DecimalDigitNumber)) || insertSeparator;
                if (!IsSpecialCharacter(current))
                {
                    if (insertSeparator && !isFirstCharacter)
                    {
                        newString[newIndex] = '-';
                        newIndex++;
                    }
                    newString[newIndex] = char.ToLowerInvariant(value[i]);
                    isFirstCharacter = false;
                    insertSeparator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToSnakeCase(this string value)
        {
            int newIndex = 0;
            bool insertSeparator = true;
            bool isFirstCharacter = true;
            UnicodeCategory previous;
            UnicodeCategory current = UnicodeCategory.OtherSymbol;
            char[] newString = new char[value.Length + CalculateSpanSizeForKebabOrSnakeCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                previous = current;
                current = char.GetUnicodeCategory(value[i]);
                insertSeparator = (previous != current && (current is UnicodeCategory.UppercaseLetter || current is UnicodeCategory.DecimalDigitNumber)) || insertSeparator;
                if (!IsSpecialCharacter(current))
                {
                    if (insertSeparator && !isFirstCharacter)
                    {
                        newString[newIndex] = '_';
                        newIndex++;
                    }
                    newString[newIndex] = char.ToLowerInvariant(value[i]);
                    isFirstCharacter = false;
                    insertSeparator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToMacroCase(this string value)
        {
            int newIndex = 0;
            bool insertSeparator = true;
            bool isFirstCharacter = true;
            UnicodeCategory previous;
            UnicodeCategory current = UnicodeCategory.OtherSymbol;
            char[] newString = new char[value.Length + CalculateSpanSizeForKebabOrSnakeCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                previous = current;
                current = char.GetUnicodeCategory(value[i]);
                insertSeparator = (previous != current && (current is UnicodeCategory.UppercaseLetter || current is UnicodeCategory.DecimalDigitNumber)) || insertSeparator;
                if (!IsSpecialCharacter(current))
                {
                    if (insertSeparator && !isFirstCharacter)
                    {
                        newString[newIndex] = '_';
                        newIndex++;
                    }
                    newString[newIndex] = char.ToUpperInvariant(value[i]);
                    isFirstCharacter = false;
                    insertSeparator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToTrainCase(this string value)
        {
            int newIndex = 0;
            bool insertSeparator = true;
            bool isFirstCharacter = true;
            UnicodeCategory previous;
            UnicodeCategory current = UnicodeCategory.OtherSymbol;
            char[] newString = new char[value.Length + CalculateSpanSizeForKebabOrSnakeCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                previous = current;
                current = char.GetUnicodeCategory(value[i]);
                insertSeparator = (previous != current && (current is UnicodeCategory.UppercaseLetter || current is UnicodeCategory.DecimalDigitNumber)) || insertSeparator;
                if (!IsSpecialCharacter(current))
                {
                    if (insertSeparator && !isFirstCharacter)
                    {
                        newString[newIndex] = '-';
                        newIndex++;
                    }
                    newString[newIndex] = insertSeparator
                        ? char.ToUpperInvariant(value[i])
                        : char.ToLowerInvariant(value[i]);
                    isFirstCharacter = false;
                    insertSeparator = false;
                    newIndex++;
                }
            }
            return new(newString);
        }

        public static string ToTitleCase(this string value)
        {
            int newIndex = 0;
            bool insertSeparator = true;
            bool isFirstCharacter = true;
            UnicodeCategory previous;
            UnicodeCategory current = UnicodeCategory.OtherSymbol;
            char[] newString = new char[value.Length + CalculateSpanSizeForKebabOrSnakeCase(value)];
            for (int i = 0; i < value.Length; i++)
            {
                previous = current;
                current = char.GetUnicodeCategory(value[i]);
                insertSeparator = (previous != current && (current is UnicodeCategory.UppercaseLetter || current is UnicodeCategory.DecimalDigitNumber)) || insertSeparator;
                if (!IsSpecialCharacter(current))
                {
                    if (insertSeparator && !isFirstCharacter)
                    {
                        newString[newIndex] = ' ';
                        newIndex++;
                    }
                    newString[newIndex] = insertSeparator
                        ? char.ToUpperInvariant(value[i])
                        : char.ToLowerInvariant(value[i]);
                    isFirstCharacter = false;
                    insertSeparator = false;
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
            int skips = IsSpecialCharacter(previous) ? 1 : 0;
            int divs = 0;
            for (int i = 1; i < text.Length; i++)
            {
                current = char.GetUnicodeCategory(text[i]);
                skips += IsSpecialCharacter(current) ? 1 : 0;
                divs += previous != current && (current is UnicodeCategory.UppercaseLetter || current is UnicodeCategory.DecimalDigitNumber) ? 1 : 0;
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
            return category is not UnicodeCategory.UppercaseLetter
                and not UnicodeCategory.LowercaseLetter
                and not UnicodeCategory.DecimalDigitNumber;
        }
    }
}