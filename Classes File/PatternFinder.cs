using System.Text.RegularExpressions;

namespace Importer.Classes_File
{
    /// <summary>
    /// Na podstawie wzorca /pattern/ przekazanego z FileOperationCenter wyszukuje dopasowań w podanym ciągu /source/
    /// </summary>
    class PatternFinder
    {
        Match match;
        private string pattern, source_copy;

        public PatternFinder(string ptrn)
        {
            pattern = ptrn;
        }
        public string search(string source)
        {
            source_copy = source;

            match = Regex.Match(source_copy, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return source = source_copy.Substring(match.Groups[0].Index + 1, match.Groups[0].Length - 2);
            }
            return null;
        }
    }
}