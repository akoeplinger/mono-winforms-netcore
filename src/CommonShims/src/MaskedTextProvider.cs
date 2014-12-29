using System.Globalization;

namespace System.Windows.Forms
{
    public class MaskedTextProvider
    {
        private CultureInfo currentCulture;
        private string mask;
        private bool value;

        public int InvalidIndex { get; set; }
        public int Length { get; set; }
        public bool AllowPromptAsInput { get; set; }
        public string Mask { get; set; }
        public bool AsciiOnly { get; set; }
        public CultureInfo Culture { get; set; }
        public char PromptChar { get; set; }
        public char PasswordChar { get; set; }
        public bool MaskCompleted { get; set; }
        public bool MaskFull { get; set; }
        public bool IsPassword { get; set; }
        public bool ResetOnPrompt { get; set; }
        public bool ResetOnSpace { get; set; }
        public bool SkipLiterals { get; set; }
        public bool IncludePrompt { get; set; }
        public bool IncludeLiterals { get; set; }

        public MaskedTextProvider(string mask, CultureInfo currentCulture)
        {
            this.mask = mask;
            this.currentCulture = currentCulture;
        }

        public MaskedTextProvider(string mask, CultureInfo currentCulture, bool value, char promptChar, char passwordChar, bool asciiOnly) : this(mask, currentCulture)
        {
            this.value = value;
            this.PromptChar = promptChar;
            this.PasswordChar = passwordChar;
            this.AsciiOnly = asciiOnly;
        }

        public bool RemoveAt(int selectionStart, int endSelection, out int testPosition, out MaskedTextResultHint resultHint)
        {
            throw new NotImplementedException();
        }

        public int FindEditPositionFrom(int selectionStart, bool v)
        {
            throw new NotImplementedException();
        }

        public bool Replace(char keyChar, int start, int end, out int testPosition, out MaskedTextResultHint resultHint)
        {
            throw new NotImplementedException();
        }

        public bool InsertAt(char keyChar, int selectionStart, out int testPosition, out MaskedTextResultHint resultHint)
        {
            throw new NotImplementedException();
        }

        public string ToString(bool v1, bool v2)
        {
            throw new NotImplementedException();
        }

        public MaskedTextProvider Clone()
        {
            throw new NotImplementedException();
        }

        public string ToDisplayString()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Set(string input, out int testPosition, out MaskedTextResultHint resultHint)
        {
            throw new NotImplementedException();
        }
    }
}