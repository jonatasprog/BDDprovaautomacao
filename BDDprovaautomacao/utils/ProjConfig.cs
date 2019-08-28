using System.IO;

namespace BDDprovaautomacao.utils

{
    class ProjConfig
    {
        public static string GetPath(string file)
        {
            return Directory.GetParent(Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.FullName).Parent.FullName + file;
        }
    }
}