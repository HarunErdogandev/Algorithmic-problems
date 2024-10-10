// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var input = "3[a2[c]]";



Console.WriteLine(decodeString(input));















string decodeString(string s)
{
    Dictionary<int,string> result = new();


    for (int i = 0; i < s.Length; i++)
    {
        var num = s[i] - '0';

        //if (char.IsDigit(s[i]))
        //{
            
        //    result.Add(s[i],"a");
        //}
    }

    return "";
}