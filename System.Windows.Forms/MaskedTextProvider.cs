using System.Globalization;

namespace System.Windows.Forms
{
    public class MaskedTextProvider
    {
        private CultureInfo currentCulture;
        private string mask;
        private bool value;

        public int InvalidIndex { get; internal set; }
        public int Length { get; internal set; }
        public bool AllowPromptAsInput { get; internal set; }
        public string Mask { get; internal set; }
        public bool AsciiOnly { get; internal set; }
        public CultureInfo Culture { get; internal set; }
        public char PromptChar { get; internal set; }
        public char PasswordChar { get; internal set; }
        public bool MaskCompleted { get; internal set; }
        public bool MaskFull { get; internal set; }
        public bool IsPassword { get; internal set; }
        public bool ResetOnPrompt { get; internal set; }
        public bool ResetOnSpace { get; internal set; }
        public bool SkipLiterals { get; internal set; }
        public bool IncludePrompt { get; internal set; }
        public bool IncludeLiterals { get; internal set; }

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

        internal bool RemoveAt(int selectionStart, int endSelection, out int testPosition, out MaskedTextResultHint resultHint)
        {
            throw new NotImplementedException();
        }

        internal int FindEditPositionFrom(int selectionStart, bool v)
        {
            throw new NotImplementedException();
        }

        internal bool Replace(char keyChar, int start, int end, out int testPosition, out MaskedTextResultHint resultHint)
        {
            throw new NotImplementedException();
        }

        internal bool InsertAt(char keyChar, int selectionStart, out int testPosition, out MaskedTextResultHint resultHint)
        {
            throw new NotImplementedException();
        }

        internal string ToString(bool v1, bool v2)
        {
            throw new NotImplementedException();
        }

        internal MaskedTextProvider Clone()
        {
            throw new NotImplementedException();
        }

        internal string ToDisplayString()
        {
            throw new NotImplementedException();
        }

        internal void Clear()
        {
            throw new NotImplementedException();
        }

        internal bool Set(string input, out int testPosition, out MaskedTextResultHint resultHint)
        {
            throw new NotImplementedException();
        }
    }
}