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
        while (! email.Equals(""))
        {
            elements = email.Split(spaces);
            foreach (string ele in elements)         
                Console.WriteLine(ele);
                email = iw.getString("email: ");
        }
    }
}