using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredReaderWV
{
    public static class StructuredReader
    {
        public static bool littleEndian = true;

        public static string Read(List<StructDefine> list, byte[] binary)
        {
            StringBuilder sb = new StringBuilder();
            MemoryStream m = new MemoryStream(binary);
            m.Seek(0, 0);
            StructDefine start = null;
            foreach (StructDefine def in list)
                if (def.name == "main")
                {
                    start = def;
                    break;
                }
            if (start == null)
                return "";
            try
            {
                sb.Append(ReadStruct("", start, list, m, 0));
            }
            catch { }
            return sb.ToString();
        }

        private static string ReadStruct(string parent, StructDefine def, List<StructDefine> list, Stream s, int tab)
        {
            StringBuilder sb = new StringBuilder();
            string tabs = "";
            for (int i = 0; i < tab; i++)
                tabs += "\t";
            sb.AppendLine(tabs + def.name + " " + parent + " {");
            foreach(TypeDefine t in def.types)
                if(Verifier.baseTypes.Contains(t.type))
                {
                    int tsize = Verifier.GetTypeSize(t.type);
                    int ttype = 0;
                    if (t.type == "float")
                        ttype = 1;
                    if (t.type == "double")
                        ttype = 2;
                    sb.Append(tabs + "\t" + t.name + " = ");
                    if (!t.isArray)
                    {
                        sb.AppendLine(ReadBinary(s, tsize, ttype));
                    }
                    else
                    {
                        sb.Append("{");
                        for (int i = 0; i < t.size - 1; i++)
                            sb.Append(ReadBinary(s, tsize, ttype) + ", ");
                        sb.AppendLine(ReadBinary(s, tsize, ttype) + "}");
                    }
                }
                else
                {
                    StructDefine def2 = null;
                    foreach(StructDefine t2 in list)
                        if(t2.name == t.type)
                        {
                            def2 = t2;
                            break;
                        }
                    if (!t.isArray)
                        sb.Append(ReadStruct(t.name, def2, list, s, tab + 1));
                    else
                    {
                        sb.AppendLine(tabs + "\t" + t.name + " = ");
                        sb.AppendLine(tabs + "\t{");
                        for (int i = 0; i < t.size; i++)
                            sb.Append(ReadStruct("[" + i + "]", def2, list, s, tab + 2));
                        sb.AppendLine(tabs + "\t}");
                    }
                }
            sb.AppendLine(tabs + "}");
            return sb.ToString();
        }

        private static string ReadBinary(Stream s, int size, int type)
        {
            byte[] buff = new byte[size];
            s.Read(buff, 0, size);
            if (!StructuredReader.littleEndian)
            {
                List<byte> tmp = new List<byte>(buff);
                tmp.Reverse();
                buff = tmp.ToArray();
            }
            StringBuilder sb = new StringBuilder();
            switch (type)
            {
                case 0:
                    sb.Append("0x");
                    switch (size)
                    {
                        case 1:
                            sb.Append(buff[0].ToString("X"));
                            break;
                        case 2:
                            sb.Append(BitConverter.ToUInt16(buff, 0).ToString("X"));
                            break;
                        case 4:
                            sb.Append(BitConverter.ToUInt32(buff, 0).ToString("X"));
                            break;
                        case 8:
                            sb.Append(BitConverter.ToUInt64(buff, 0).ToString("X"));
                            break;
                    }
                    break;
                case 1:
                    sb.Append(BitConverter.ToSingle(buff, 0).ToString() + "f");
                    break;
                case 2:
                    sb.Append(BitConverter.ToDouble(buff, 0).ToString());
                    break;
            }
            return sb.ToString();
        }
    }
}
