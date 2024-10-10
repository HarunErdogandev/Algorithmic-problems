// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




//strs = ["flower","flow","flight"];

int count = 1;




Console.WriteLine(LongestCommonPrefix1(new string[] { "flower", "flow", "flight" }));



string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
        return ""; // Boş dizi kontrolü

    string prefix = strs[0]; // İlk elemanı al

    for (int i = 1; i < strs.Length; i++)
    {
		
        while (strs[i].IndexOf(prefix) != 0)
        {
            prefix = prefix.Substring(0, prefix.Length - 1); // Prefix'i kısalt
            if (prefix.Length == 0) return ""; // Prefix boşsa
        }
    }
    return prefix;
}



string LongestCommonPrefix1(string[] strs)
{



    var prefix=strs[0];

	for (int i = 0; i < strs.Length; i++)
	{
		while (strs[i].IndexOf(prefix)!=0)
		{
			prefix=prefix.Substring(0, prefix.Length - 1);
			if(prefix.Length == 0)
				return "";
		}
	}

	return prefix;

}


bool Counter(int length)
{
   
    count++;
	

    if (count == length)
	{
		count = 1;
		return true;
	}
	return false;

}
        

	
	
	
	
	
	


	
	

