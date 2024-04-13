using System;


class SortClass
{
    public void selection(int[] arr)
    {
        // Soritng by SELECTIOn Algorithm
        int tmp;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[min] > arr[j])
                    min = j;
            } // for j
            tmp = arr[i]; // swapig part
            arr[i] = arr[min];
            arr[min] = tmp;
        }// for i
        Console.WriteLine("\n-- Selection Sort --");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("\n");
    } // Selection

    public void Bubble(int[] arr)
    {

        int swap1 = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swap1 += 1;
                }
            }
        }

        Console.WriteLine("\n------------ Bubble Sort -------------\n");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    } // Bubble

    public void quickSort(int[] arr, int start, int end)
    {
        if (end <= start) return; // base case
        int pivot = partition(arr, start, end);
        quickSort(arr, start, pivot - 1);
        quickSort(arr, pivot + 1, end);

    } // Quick Sort

    public int partition(int[] arr, int start, int end)
    {
        int pivot = arr[end];
        int i = start - 1;
        for (int j = start; j <= end - 1; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp1 = arr[i];
                arr[i] = arr[j];
                arr[j] = temp1;
            }
        }
        i++;
        int temp = arr[i];
        arr[i] = arr[end];
        arr[end] = temp;

        for (int n = 0; n < arr.Length; n++)
        {
            Console.Write(arr[n] + " ");
        }

        return i;
   }// Partition

  public  void MergeSorting(int[] arr)
{
    int len = arr.Length;
    if (len <= 1) return;

    int middle = len / 2;
    int[] leftArr = new int[middle];
    int[] rightArr = new int[len - middle];

    // Copy elements to left and right arrays
    for (int i = 0; i < middle; i++)
    {
        leftArr[i] = arr[i];
    }
    for (int i = middle; i < len; i++)
    {
        rightArr[i - middle] = arr[i];
    }

    MergeSorting(leftArr);
    MergeSorting(rightArr);
    Merging(leftArr, rightArr, arr);
}

public void  Merging(int[] leftArr, int[] rightArr, int[] arr)
{
    int leftSize = leftArr.Length;
    int rightSize = rightArr.Length;
    int i = 0, l = 0, r = 0;

    // Merge left and right arrays into arr
    while (l < leftSize && r < rightSize)
    {
        if (leftArr[l] <= rightArr[r])
        {
            arr[i++] = leftArr[l++];
        }
        else
        {
            arr[i++] = rightArr[r++];
        }
    }

    // Copy remaining elements of leftArr if any
    while (l < leftSize)
    {
        arr[i++] = leftArr[l++];
    }

    // Copy remaining elements of rightArr if any
    while (r < rightSize)
    {
        arr[i++] = rightArr[r++];
    }

    // No need to print here, just sorting the array
}
  
}
