using System;

public class EmailStringe
{
    public static void Main()
    {
        InputWrapper iw = new InputWrapper();
        char[] spaces = { '@', '.' };
        string[] elements;
        Console.WriteLine("Enter a string, empty string to end");
        string email = iw.getString("email: ");
        while (!email.Equals(""))
        {
            elements = email.Split(spaces);
            foreach (string ele in elements)
                Console.WriteLine(ele);
            email = iw.getString("email: ");
            int index = email.IndexOf('@', 0);
            if (index != -1)
            {
                string user = email.Substring(0, index);
                int start = index + 1;
                index = email.IndexOf('.', index);
                if (index != -1)
                {
                    string domain = email.Substring(start, index - start);
                    string suffix = email.Substring(index + 1);
                    if (suffix == "com" || suffix == "org" || suffix == "edu")
                    {
                        Console.WriteLine("user = {0}", user);
                        Console.WriteLine("domain = {0}", domain);
                        Console.WriteLine("suffix = {0}", suffix);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Legal suffixes are .com, .org, .edu");
                        break;
                    }
                }
            }
        }
    }
}