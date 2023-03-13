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
        //int[] bubbleSortedArrayAsc = Sort(intArray, OrderBy.Asc, SortAlgorithmType.Bubble);
        //int[] bubbleSortedArrayDesc = Sort(intArray, OrderBy.Desc, SortAlgorithmType.Bubble);
        //int[] selectionSortedArrayAsc = Sort(intArray, OrderBy.Asc, SortAlgorithmType.Selection);
        //int[] selectionSortedArrayDesc = Sort(intArray, OrderBy.Desc, SortAlgorithmType.Selection);
        //int[] insertionSortedArrayAsc = Sort(intArray, OrderBy.Asc, SortAlgorithmType.Insertion);
        //int[] insertionSortedArrayDesc = Sort(intArray, OrderBy.Desc, SortAlgorithmType.Insertion);

        static int[] Sort(int[] array, OrderBy order, SortAlgorithmType type)
        {
            int[] sortedArray = array;
            string orderType = "";
            switch (order)
            {
                case OrderBy.Asc:
                    orderType = "Asc";
                    break;
                case OrderBy.Desc:
                    orderType = "Desc";
                    break;
            }

            switch (type)
            {
                case SortAlgorithmType.Bubble:
                    sortedArray = array;
                    for (int i = 0; i < sortedArray.Length - 1; i++)
                    {
                        for (int j = i+1; j < sortedArray.Length; j++)
                        {
                            if (sortedArray[i] > sortedArray[j])
                            {
                                int temp = sortedArray[i];
                                sortedArray[i] = sortedArray[j];
                                sortedArray[j] = temp;
                            }
                        }
                    }
                    if (orderType == "Desc")
                    {
                        for (int i = 0; i < sortedArray.Length/2; i++)
                        {
                            int temp = sortedArray[i];
                            sortedArray[i] = sortedArray[sortedArray.Length - i-1];
                            sortedArray[sortedArray.Length-i-1] = temp;
                        }
                    }
                    break;
                case SortAlgorithmType.Insertion:
                    sortedArray = array;
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
                    if (orderType == "Desc")
                    {
                        for (int i = 0; i < array.Length / 2; i++)
                        {
                            int temp = sortedArray[i];
                            sortedArray[i] = sortedArray[sortedArray.Length - i - 1];
                            sortedArray[sortedArray.Length - i - 1] = temp;
                        }
                    }
                    break;
                case SortAlgorithmType.Selection:
                    sortedArray= array;
                    for (int i = 0; i < sortedArray.Length - 1; i++)
                    {
                        int minIndx = i;
                        for (int j = i+1; j < sortedArray.Length; j++)
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
                    if (orderType == "Desc")
                    {
                        for (int i = 0; i < sortedArray.Length / 2; i++)
                        {
                            int temp = sortedArray[i];
                            sortedArray[i] = sortedArray[sortedArray.Length - i - 1];
                            sortedArray[sortedArray.Length - i - 1] = temp;
                        }
                    }
                    break;
            }
            return sortedArray;
        }
    }
}