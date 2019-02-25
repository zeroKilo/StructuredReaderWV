using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredReaderWV
{
    public static class Parser
    {
        public static List<Token> ParseString(string s)
        {
            List<Token> result = new List<Token>();
            StringReader sr = new StringReader(s.Trim());
            while (sr.Peek() != -1)
                result.Add(ReadToken(sr));
            return result;
        }

        public static Token ReadToken(StringReader sr)
        {
            char[] dummy = new char[1];
            int peek;
            string test = "\t\r\n ";
            while (true)
            {
                peek = sr.Peek();
				if (test.Contains((char)peek))
					sr.Read(dummy, 0, 1);
				else
					break;
            }
            List<Token> tmp = new List<Token>() { new TokenAlpha(), new TokenNumeric(), new TokenSpecial() };
            foreach(Token t in tmp)
                if(t.isCharThisType((char)peek))
                {
                    t.ReadFromStream(sr);
                    return t;
                }
            return null;
        }
    }

    public abstract class Token
    {
        public string text;
        public string name;
        public string detect;
        public string allowed;
        public bool isSpecial = false;
		public bool isHex = false;
        public bool isCharThisType(char c)
        {
            return detect.Contains(c);
        }

        public void ReadFromStream(StringReader sr)
        {
            int peek;
            StringBuilder sb = new StringBuilder();
            char[] dummy = new char[1];
            while (true)
            {
                peek = sr.Peek();
                if (allowed.Contains((char)peek))
                {
                    sb.Append((char)peek);
                    sr.Read(dummy, 0, 1);
                }
                else
                    break;
                if (isSpecial)
                    break;
            }
			text = sb.ToString().ToLower();
        }
    }

    public class TokenAlpha : Token
    {
        public TokenAlpha()
        {
            name = "Text";
            detect = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_";
            allowed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_-0123456789xX";
        }
    }

    public class TokenNumeric : Token
    {
        public TokenNumeric()
        {
            name = "Number";
            detect = allowed = "0123456789";
        }
    }

    public class TokenSpecial : Token
    {
        public TokenSpecial()
        {
            isSpecial = true;
            name = "Special";
            detect = allowed = "{[]};";
        }
    }
}
