namespace ThreeSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = [1,2,3,4,1,2,3,4,1,2,3,1,2,3,4,5,6,7,8,9,1,2,3,4,5,6,7,8,9];
            FindTriplets(array, 14);
        }

        static void FindTriplets(int[] arr, int targetSum)
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 2; i++)
            {
                int left = i + 1;
                int right = arr.Length - 1;

                while (left < right)
                {
                    int currentSum = arr[i] + arr[left] + arr[right];

                    if (currentSum == targetSum)
                    {
                        Console.WriteLine("Три числа, сумма которых равна " + targetSum + ": " + arr[i] + ", " + arr[left] + ", " + arr[right]);
                        return;
                    }
                    else if (currentSum < targetSum)
                    {
                        left++;
                    }
                    else // currentSum > targetSum
                    {
                        right--;
                    }
                }
            }

            Console.WriteLine("Такие три числа не найдены в массиве.");
        }
    }
}
