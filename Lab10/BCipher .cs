

namespace Lab10
{
    internal class BCipher : ICipher
    {
        public string encode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (char.IsUpper(chars[i]))
                    {
                        chars[i] = (char)('Z' - (chars[i] - 'A'));
                    }
                    else
                    {
                        chars[i] = (char)('z' - (chars[i] - 'a'));
                    }
                }
            }

            return new string(chars);
        }


        public string decode(string text)
        {
            return encode(text);
        }
    }
}
