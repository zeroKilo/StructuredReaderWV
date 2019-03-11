using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredReaderWV
{
    public static class Lexer
    {
        public static string ErrorOut = "";

        public static List<StructDefine> Parse(List<Token> input)
        {
            ErrorOut = "";
            List<StructDefine> result = new List<StructDefine>();
            int pos = 0;
            try
            {
                while (pos < input.Count)
                {
                    if (input[pos].text == "struct")
                    {
                        pos++;
                        if (input[pos] is TokenAlpha && input[pos + 1].text == "{")
                        {
                            StructDefine def = new StructDefine();
                            def.name = input[pos].text;
                            def.types = new List<TypeDefine>();
                            pos += 2;
                            while (true)
                            {
                                if (input[pos] is TokenAlpha && input[pos + 1] is TokenAlpha)
                                {
                                    TypeDefine tdef = new TypeDefine();
                                    tdef.type = input[pos].text;
                                    tdef.name = input[pos + 1].text;
                                    pos += 2;
                                    if (input[pos].text == ";")
                                    {
                                        tdef.isArray = false;
                                        tdef.size = 0;
                                        def.types.Add(tdef);
                                        pos++;
                                    }
                                    else if (input[pos].text == "[")
                                    {
                                        pos++;
                                        if (input[pos] is TokenNumeric &&
                                            input[pos + 1].text == "]" &&
                                            input[pos + 2].text == ";")
                                        {
                                            tdef.isArray = true;
                                            tdef.size = Convert.ToInt32(input[pos].text);
                                            def.types.Add(tdef);
                                            pos += 3;
                                        }
                                        else if (input[pos] is TokenNumeric && 
                                                 input[pos].text == "0" &&
                                                 input[pos + 1] is TokenAlpha  &&
                                                 input[pos + 1].text.ToLower().StartsWith("x") &&
                                                 input[pos + 2].text == "]" &&
                                                 input[pos + 3].text == ";")
                                        {
                                            tdef.isArray = true;
                                            tdef.size = Convert.ToInt32(input[pos + 1].text.Substring(1), 16);
                                            def.types.Add(tdef);
                                            pos += 4;
                                        }
                                        else
                                            throw new Exception("Expected array definition");
                                    }
                                    else
                                        throw new Exception("Expected array define or end of define ; semicolon");
                                }
                                else if (input[pos].text == "}")
                                    break;
                                else
                                    throw new Exception("Expected new type definition or end of structure definition");
                            }
                            pos++;
                            result.Add(def);
                        }
                        else
                            throw new Exception("Expected 'struct NAME {' next");
                    }
                    else
                        throw new Exception("Expected 'struct' next, got instead '" + input[pos].text + "'");
                }
            }
            catch (Exception ex)
            {
                ErrorOut = ex.Message;
            }
            return result;
        }
    }

    public class StructDefine
    {
        public bool marked;
        public string name;
        public List<TypeDefine> types;
    }

    public class TypeDefine
    {
        public bool isArray;
        public string type;
        public string name;
        public int size;
    }
}
