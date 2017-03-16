using System.Collections.Generic;
using System.Text.RegularExpressions;

class TypeDetector
{
    Regex regExp;
    Match match;
    private List<string> content;
    private string detected_type;
    private string pattern;
    private string [] arr;
    private bool find;
    private int i, index, len;

    public TypeDetector(ref List<string> cnt)
    {
        content = cnt;
        find = false;
        i = 0;
        pattern = "[>]{1}\\s*\\w{3,}\\s*\\w{3,}[<]{1}";
        regExp = new Regex(pattern);
    }

    public void findType()
    {
        arr = content.ToArray();

        while(find != true)
        {
            match = Regex.Match(arr[i], pattern, RegexOptions.IgnoreCase);

            if (arr[i].Contains("<TITLE>"))
            {
                i++;
                continue;
            }
            if (match.Success)
            {
                index = match.Groups[0].Index + 1;
                len = match.Groups[0].Length-2;
                detected_type = arr[i].Substring(index, len);
                find = true;
            }
            i++;
        }
    }

    public string getType()
    {
        return detected_type;
    }
}

