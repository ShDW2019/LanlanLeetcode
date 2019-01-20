using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class LowerCase
{
    public string ToLowerCase(string str)
    {

        if (string.IsNullOrEmpty(str))
        {
            return "";
        }

        int len = str.Length;
        char[] data = str.ToArray();
        for (int i = 0; i < len; i++)
        {
            char c = data[i];
            if (c >= 'A' && c <= 'Z')
            {
                //do something to lower case
                int distance = (c + 'a' - 'A');
                data[i] = (char)distance;
            }
        }

        string str1 = new string(data);
        return str1;
    }
}