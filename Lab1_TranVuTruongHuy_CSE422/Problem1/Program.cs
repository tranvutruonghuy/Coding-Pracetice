namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfNums1 = int.Parse(Console.ReadLine());
            int lengthOfNums2 = int.Parse(Console.ReadLine());
            int[] nums1 = new int[lengthOfNums1];
            int[] nums2 = new int[lengthOfNums2];
            for (int i = 0; i < lengthOfNums1; i++) 
            {
                nums1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < lengthOfNums2; i++)
            {
                nums2[i] = int.Parse(Console.ReadLine());
            }
            double medianValue = FindMedianSortedArrays(nums1 , nums2);
            Console.WriteLine(medianValue);
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> merged = MergeSortedArrays(nums1, nums2);
            return CalculateMedian(merged);
        }

        public static List<int> MergeSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> merged = new List<int>();
            int indexInNums1 = 0, indexInNums2 = 0;

            while (indexInNums1 < nums1.Length && indexInNums2 < nums2.Length)
            {
                if (nums1[indexInNums1] < nums2[indexInNums2])
                {
                    merged.Add(nums1[indexInNums1++]);
                }
                else
                {
                    merged.Add(nums2[indexInNums2++]);
                }
            }

            while (indexInNums1 < nums1.Length) merged.Add(nums1[indexInNums1++]);
            while (indexInNums2 < nums2.Length) merged.Add(nums2[indexInNums2++]);

            return merged;
        }

        public static double CalculateMedian(List<int> merged)
        {
            int mid = merged.Count / 2;
            if (merged.Count % 2 == 0)
            {
                return (merged[mid - 1] + merged[mid]) / 2.0;
            }
            else
            {
                return merged[mid];
            }
        }
    }
}
