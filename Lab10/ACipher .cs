using System;

namespace Lab10
{
     class ACipher : ICipher
    {
        public string encode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (Char.IsLetter(c))
                {
                    if (c == 'Z')
                        chars[i] = 'A';
                    else if (c == 'z')
                        chars[i] = 'a';
                    else if (c == 'Я')
                        chars[i] = 'А';
                    else if (c == 'я')
                        chars[i] = 'a';
                    else
                        chars[i] = (char)(c + 1);
                }
            }
            return new string(chars);
        }

        public string decode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (Char.IsLetter(c))
                {
                    if (c == 'A')
                        chars[i] = 'Z';
                    else if (c == 'a')
                        chars[i] = 'z';
                    else if (c == 'Я')
                        chars[i] = 'А';
                    else if (c == 'я')
                        chars[i] = 'a';
                    else
                        chars[i] = (char)(c - 1);
                }
            }
            return new string(chars);
        }
    }
}
