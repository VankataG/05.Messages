namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int elements = nums.Length;

            if (nums.Length > 1)

            {
                while (elements > 1)
                {
                    for (int i = 0; i < nums.Length - 1; i++)
                    {
                        nums[i] = nums[i] + nums[i + 1];
                    }
                    elements--;
                }
                Console.WriteLine(nums[0]);
            }
            else
            {
                Console.Write(nums[0]);
            }
        }
    }
}
