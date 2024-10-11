// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//"()[]{}"
//"([{}])"
//"([)]"
// 40 41,91 93, 123 125;
   //-1
// ( stack ekledi bir sonraki ) 
Console.WriteLine(IsValid("([]){"));



//(stack.Peek() - 0) - (s[i] - 0) == -1 || (stack.Peek() - 0) - (s[i] - 0) == -2 


bool IsValid(string s)
{
    char[] openingBrackets = { '(', '{', '[' };

    Stack<char> stack = new Stack<char>();

    
    if (s.Length == 1) return false;

    for (int i = 0; i < s.Length; i++)
    {
        if (openingBrackets.Contains(s[i]))
            stack.Push(s[i]);
        else if (stack.Count != 0)
        {
            var isMatchingBracket = (stack.Peek() - 0) - (s[i] - 0) == -1
            || (stack.Peek() - 0) - (s[i] - 0) == -2;

            if (isMatchingBracket)
            {
                stack.Pop();
                
            }
            else
                return false;
        }
        else 
            return false;
    }


    return stack.Count == 0;

}

bool IsValid2(string s)
{
    Stack<char> stack = new Stack<char>();

    if (s.Length == 1) return false;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(' || s[i] == '[' || s[i] == '{')
        {
            stack.Push(s[i]);
        }
        else if (stack.Count != 0)
        {
            char open = stack.Peek();
            if ((open == '(' && s[i] == ')') ||
                (open == '[' && s[i] == ']') ||
                (open == '{' && s[i] == '}'))
            {
                stack.Pop();
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    return stack.Count == 0;
}
