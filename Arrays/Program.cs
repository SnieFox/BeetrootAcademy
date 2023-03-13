enum SortAlgorithmType
{
    Selection,
    Bubble,
    Insertion
}

enum OrderBy
{
    Asc,
    Desc
}

class Program
{
    static void Main(string[] args)
    {
        int[] intArray = {11,1,4,8,2,66,13,10};
        // ?????????????
        //int[] bubbleSortedArrayAsc = Sort(intArray, OrderBy.Asc, SortAlgorithmType.Bubble);
        //int[] bubbleSortedArrayDesc = Sort(intArray, OrderBy.Desc, SortAlgorithmType.Bubble);
        //int[] selectionSortedArrayAsc = Sort(intArray, OrderBy.Asc, SortAlgorithmType.Selection);
        //int[] selectionSortedArrayDesc = Sort(intArray, OrderBy.Desc, SortAlgorithmType.Selection);
        //int[] insertionSortedArrayAsc = Sort(intArray, OrderBy.Asc, SortAlgorithmType.Insertion);
        //int[] insertionSortedArrayDesc = Sort(intArray, OrderBy.Desc, SortAlgorithmType.Insertion);

        PrintArray(Sort(intArray, OrderBy.Asc, SortAlgorithmType.Bubble));
        PrintArray(Sort(intArray, OrderBy.Desc, SortAlgorithmType.Bubble));
        PrintArray(Sort(intArray, OrderBy.Asc, SortAlgorithmType.Selection));
        PrintArray(Sort(intArray, OrderBy.Desc, SortAlgorithmType.Selection));
        PrintArray(Sort(intArray, OrderBy.Asc, SortAlgorithmType.Insertion));
        PrintArray(Sort(intArray, OrderBy.Desc, SortAlgorithmType.Insertion));
        Console.Read();
    }

    static void PrintArray(int[] array)
    {
        string str = "";
        foreach (var i in array)
        {
            str += $"{i} ";
        }

        Console.WriteLine(str);
    }
    static int[] Sort(int[] array, OrderBy order, SortAlgorithmType type)
    {
        switch (type)
        {
            case SortAlgorithmType.Bubble:
                return BubbleSort(array,order);
            case SortAlgorithmType.Insertion:
                return InsertionSort(array, order);
            case SortAlgorithmType.Selection:
                return SelectionSort(array, order);
            default: 
                return array;
        }
    }
    static int[] BubbleSort(int[] array, OrderBy order)
    {
        int[] sortedArray = array;
        for (int i = 0; i < sortedArray.Length - 1; i++)
        {
            for (int j = i + 1; j < sortedArray.Length; j++)
            {
                if (sortedArray[i] > sortedArray[j])
                {
                    int temp = sortedArray[i];
                    sortedArray[i] = sortedArray[j];
                    sortedArray[j] = temp;
                }
            }
        }
        if (order == OrderBy.Desc)
        {
            for (int i = 0; i < sortedArray.Length / 2; i++)
            {
                int temp = sortedArray[i];
                sortedArray[i] = sortedArray[sortedArray.Length - i - 1];
                sortedArray[sortedArray.Length - i - 1] = temp;
            }
        }
        return sortedArray;
    }
    static int[] InsertionSort(int[] array, OrderBy order)
    {
        int[] sortedArray = array;
        for (int i = 1; i < sortedArray.Length; ++i)
        {
            int temp = sortedArray[i];
            int j = i - 1;

            while (j >= 0 && sortedArray[j] > temp)
            {
                sortedArray[j + 1] = sortedArray[j];
                j = j - 1;
            }
            sortedArray[j + 1] = temp;
        }
        if (order == OrderBy.Desc)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = sortedArray[i];
                sortedArray[i] = sortedArray[sortedArray.Length - i - 1];
                sortedArray[sortedArray.Length - i - 1] = temp;
            }
        }
        return sortedArray;
    }
    static int[] SelectionSort(int[] array, OrderBy order)
    {
        int[] sortedArray = array;
        for (int i = 0; i < sortedArray.Length - 1; i++)
        {
            int minIndx = i;
            for (int j = i + 1; j < sortedArray.Length; j++)
            {
                if (sortedArray[j] < sortedArray[minIndx])
                {
                    minIndx = j;
                }
            }
            int temp = sortedArray[minIndx];
            sortedArray[minIndx] = sortedArray[i];
            sortedArray[i] = temp;
        }
        if (order == OrderBy.Desc)
        {
            for (int i = 0; i < sortedArray.Length / 2; i++)
            {
                int temp = sortedArray[i];
                sortedArray[i] = sortedArray[sortedArray.Length - i - 1];
                sortedArray[sortedArray.Length - i - 1] = temp;
            }
        }
        return sortedArray;
    }

}