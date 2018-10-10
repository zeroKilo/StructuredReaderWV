# Structured Reader by Warranty Voider

This tool takes as input a binary file and a c style structure definition and then applies it to the binary file.

This way you can quickly check file headers or guess binary structures in files

- Supports big and little endian
- Supports arrays
- Supports nested structs

* Supported types: 

1 byte : "byte", "char", "uchar", "int8_t", "uint8_t"
2 bytes :  "short", "ushort", "word", "int16_t", "uint16_t"
4 bytes : "int", "uint", "dword", "int32_t", "uint32_t", "float", "single"
8 bytes : "long", "ulong", "qword", "int64_t", "uint64_t", "double"

Example Different Types
<img src="https://i.imgur.com/CLuunAM.png"></img>

Example Bitmap Header
<img src="https://i.imgur.com/HRWi0BU.png"></img>