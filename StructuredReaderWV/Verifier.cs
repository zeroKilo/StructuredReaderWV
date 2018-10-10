using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredReaderWV
{
    public static class Verifier
    {
        public static Dictionary<int, string[]> baseTypeSizes = new Dictionary<int, string[]>
        {
            { 1, new string[] { "byte", "char", "uchar", "int8_t", "uint8_t"} },
            { 2, new string[] { "short", "ushort", "word", "int16_t", "uint16_t" } },
            { 4, new string[] { "int", "uint", "dword", "int32_t", "uint32_t", "float", "single" } },
            { 8, new string[] { "long", "ulong", "qword", "int64_t", "uint64_t", "double" } },
        };

        public static string[] baseTypes = { "byte", "char", "uchar", "int8_t", "uint8_t", "short", "ushort", "word", "int16_t", "uint16_t", "int", "uint", "dword", "int32_t", "uint32_t", "float", "single", "long", "ulong", "qword", "int64_t", "uint64_t", "double" };

        public static string ErrorOut;

        public static int GetTypeSize(string t)
        {
            foreach (int size in baseTypeSizes.Keys)
                foreach (string t2 in baseTypeSizes[size])
                    if (t2 == t)
                        return size;
            return 0;
        }
        public static bool Verify(List<StructDefine> list)
        {
            ErrorOut = "";
            StructDefine start = null;
            foreach(StructDefine def in list)
                if(def.name == "main")
                {
                    start = def;
                    break;
                }
            if (start == null)
            {
                ErrorOut = "cant find start struct named 'main'";
                return false;
            }
            for (int i = 0; i < list.Count; i++)
                list[i].marked = false;
            return Check(start, list);
        }

        private static bool Check(StructDefine def, List<StructDefine> list)
        {
            def.marked = true;
            if (baseTypes.Contains(def.name))
            {
                ErrorOut = "unknown type found '" + def.name + "'";
                return false;
            }
            foreach (TypeDefine t in def.types)
                if (baseTypes.Contains(t.type))
                    continue;
                else
                {
                    StructDefine sub = null;
                    foreach(StructDefine t2 in list)
                        if(t2.name == t.type)
                        {
                            sub = t2;
                            break;
                        }
                    if (sub == null)
                    {
                        ErrorOut = "couldnt find definition for struct type '" + t.type + "'";
                        return false;
                    }
                    if (sub.marked)
                    {
                        ErrorOut = "recursive reference found";
                        return false;
                    }
                    return Check(sub, list);
                }
            return true;
        }
    }
}
