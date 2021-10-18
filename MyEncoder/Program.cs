using System;
using System.Text;

class Example
{
    static void Main()
    {
        string unicodeString = "(\u0022enableCache\u0022:false,\u0022hasTechnicalError\u0022:false,\u0022processingError\u0022:{\u0022BatchId\u0022:\u0022fdc659d3-a390-49d0-9117-eae23e16c772\u0022,\u0022CodeOfError\u0022:-11,\u0022TextOfError\u0022:\u0022\\u041D\\u0430\\u0440\\u0443\\u0448\\u0435\\u043D \\u043F\\u0440\\u043E\\u0442\\u043E\\u043A\\u043E\\u043B \\u043E\\u0431\\u0449\\u0435\\u043D\\u0438\\u044F \\u0441 \\u041C\\u041A-\\u041E\\u043D\\u043B\\u0430\\u0439\\u043D. \\u0422\\u0435\\u0445\\u043D\\u0438\\u0447\\u0435\\u0441\\u043A\\u0430\\u044F \\u0438\\u043D\\u0444\\u043E\\u0440\\u043C\\u0430\\u0446\\u0438\\u044F: \\u0423 \\u043F\\u0430\\u0447\\u043A\\u0438 \\u0441 \\u0438\\u0434\\u0435\\u043D\\u0442\\u0438\\u0444\\u0438\\u043A\\u0430\\u0442\\u043E\\u0440\\u043E\\u043C [fdc659d3-a390-49d0-9117-eae23e16c772] \\u043D\\u0435 \\u043D\\u0430\\u0439\\u0434\\u0435\\u043D\\u043E \\u043E\\u043F\\u0438\\u0441\\u0430\\u043D\\u0438\\u0435 \\u0434\\u043E\\u043A\\u0443\\u043C\\u0435\\u043D\\u0442\\u043E\\u0432!\u0022})";



        Encoding ascii = Encoding.ASCII;
        Encoding unicode = Encoding.Unicode;

        byte[] unicodeBytes = unicode.GetBytes(unicodeString);
        byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);
        char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
        ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
        string asciiString = new string(asciiChars);

        Console.WriteLine("Original string: {0}", unicodeString);
        Console.WriteLine("Ascii converted string: {0}", asciiString);
    }
}