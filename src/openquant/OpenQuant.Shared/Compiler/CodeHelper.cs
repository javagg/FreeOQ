using System.IO;

namespace OpenQuant.Shared.Compiler
{
    public static class CodeHelper
    {
        public const string FILE_EXTENSION_CSHARP = ".cs";
        public const string FILE_EXTENSION_VISUALBASIC = ".vb";

        public static CodeLang GetCodeLang(FileInfo file)
        {
            switch (file.Extension.ToLower())
            {
                case FILE_EXTENSION_CSHARP:
                    return CodeLang.CSharp;
                case FILE_EXTENSION_VISUALBASIC:
                    return CodeLang.VisualBasic;
                default:
                    return CodeLang.None;
            }
        }

        public static CodeLang GetCodeLang(string filename)
        {
            return CodeHelper.GetCodeLang(new FileInfo(filename));
        }

        public static string GetFileExtension(CodeLang codeLang)
        {
            switch (codeLang)
            {
                case CodeLang.CSharp:
                    return FILE_EXTENSION_CSHARP;
                case CodeLang.VisualBasic:
                    return FILE_EXTENSION_VISUALBASIC;
                default:
                    return string.Empty;
            }
        }
    }
}
