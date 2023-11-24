/*
    public void MergeSorting(int[] arr)
    {
        int len = arr.Length;
        if (len <= 1) return;

        int middle = len / 2;
        int[] leftArr = new int[middle];
        int[] rightArr = new int[len - middle];

        int i = 0; // left array
        int j = 0; // right array

        for (; i < len; i++)
        {
            if (i < middle)
            {
                leftArr[i] = arr[i];
            }
            else
            {
                rightArr[j] = arr[i];
                j++;
            }
        }

        MergeSorting(leftArr);
        MergeSorting(rightArr);
        Merging(leftArr, rightArr, arr);
    }

    private  void Merging(int[] leftArr, int[] rightArr, int[] arr)
    {
        int leftSize = arr.Length / 2;
        int rightSize = arr.Length - leftSize;
        int i = 0, l = 0, r = 0;

        while (l < leftSize && r < rightSize)
        {
            if (leftArr[l] < rightArr[r])
            {
                arr[i] = leftArr[l];
                i++;
                l++;
            }
            else
            {
                arr[i] = rightArr[r];
                i++;
                r++;
            }
        }

        while (l < leftSize)
        {
            arr[i] = leftArr[l];
            i++;
            l++;
        }

        while (r < rightSize)
        {
            arr[i] = rightArr[r];
            i++;
            r++;
        }

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
*/

