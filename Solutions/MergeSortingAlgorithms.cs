namespace Solutions
{
    public static class MergeSortingAlgorithms
    {
        public static int[] MergeTwoSortedArrays(int[] a, int[] b)
        {
            int k = a.Length + b.Length;
            int[] c = new int[k];

            int pointerA = 0, pointerB = 0;
            k = 0;

            while (pointerA < a.Length && pointerB < b.Length)
            {
                if (a[pointerA] < b[pointerB])
                {
                    c[k++] = a[pointerA++];
                }
                else
                {
                    c[k++] = b[pointerB++];
                }
            }

            for (; pointerA < a.Length; pointerA++)
            {
                c[k++] = a[pointerA];
            }

            for (; pointerB < b.Length; pointerB++)
            {
                c[k++] = b[pointerB];
            }

            return c;
        }
    }
}