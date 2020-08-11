using System.Text;

namespace fileParserTest
{
    public class StringParser
    {
        private readonly bool removePunctuation;
        private readonly uint minWordLength;
        private readonly StringBuilder currentWord = new StringBuilder();

        public StringParser(uint minWordLength, bool removePunctuation)
        {
            this.minWordLength = minWordLength;
            this.removePunctuation = removePunctuation;
        }

        public string Parse(char[] input, bool isEOF)
        {
            StringBuilder output = new StringBuilder();
            int inputLength = input.Length;

            for (int i = 0; i < inputLength; i++)
            {
                // Встретили букву слова
                if (char.IsLetterOrDigit(input[i]))
                {
                    currentWord.Append(input[i]);
                    continue;
                }

                //Встретили символ отличный от буквы
                if (currentWord.Length >= minWordLength)
                {
                    output.Append(currentWord.ToString());
                }

                currentWord.Clear();

                // Дошли до последнего блока, встретились с '\0'
                if (input[i] == '\0')
                {
                    break;
                }

                // Встретили пробельный символ
                if (char.IsWhiteSpace(input[i]))
                {
                    output.Append(input[i]);
                    continue;
                }

                // Встретили знак пунктуации при режиме удаления
                if (char.IsPunctuation(input[i]) && removePunctuation)
                {
                    continue;
                }

                // Встретили любой другой символ(или не удаляем знаки препинания)
                output.Append(input[i]);
            }

            if (isEOF && currentWord.Length >= minWordLength)
            {
                output.Append(currentWord.ToString());
            }

            return output.ToString();
        }
    }
}
