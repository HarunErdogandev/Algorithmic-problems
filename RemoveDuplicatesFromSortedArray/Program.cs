// See https://aka.ms/new-console-template for more information


//[0,0,1,1,1,2,2,3,3,4]



int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };


RemoveDuplicates(nums);

int RemoveDuplicates(int[] nums)
{
    int currentNum = 0;
    int prevNum = 0;
    int k = 0;
    prevNum= nums[0];
    for(int i = 1; i < nums.Length; i++)
    {
        currentNum= nums[i];
        if (currentNum==prevNum)
        {
            prevNum = currentNum;
            
        }
        else
        {
            var a=    Array.IndexOf(nums, 1);
        }
       

    }
    return 1;
}