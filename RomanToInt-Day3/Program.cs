// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4. */


Console.WriteLine(RomanToInt("MCMXCIV"));


//stack= 1000 100 1000 10 100 1 5

int RomanToInt(string s)
{
    var charArray = s.ToCharArray();
   
    int result = 0;
    int prevValue = 0;

    for (int i = charArray.Length - 1; i >= 0; i--)
    {
        int value = RomanDefinition(charArray[i]);
        if (value < prevValue)
            result -= value;
        else
            result += value;

        prevValue = value;
    }

    return result;




}

static int RomanDefinition(char y)
{

    var num = y switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => 0
    };


    return num;
}


//int returnNum(int s, int x) => x - s;









