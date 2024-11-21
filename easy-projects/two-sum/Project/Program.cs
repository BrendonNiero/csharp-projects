static void Main()
{
    // Exemplo de uso
    int[] nums = { 1, 2, 3, 4, 5 };
    int target = 9;
    try
    {
        int[] result = TwoSum(nums, target);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine(e.Message);
    }
}
static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (map.ContainsKey(complement))
        {
            return new int[] { map[complement], i };
        }
        map[nums[i]] = i;
    }
    throw new InvalidOperationException("Nenhuma solução encontrada.");
}

