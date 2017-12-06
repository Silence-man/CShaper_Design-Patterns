namespace Adapter
{
    class OperationAdapter : ScoreOperation
    {
        private QuickSortClass sortObj; //定义适配者QuickSortClass对象
        private BinarySearchClass searchObj; //定义适配者BinarySearchClass对象

	    public OperationAdapter() 
        {
            sortObj = new QuickSortClass();
            searchObj = new BinarySearchClass();
	    }

	    public int[] Sort(int[] array) 
        {
            return sortObj.QuickSort(array); //调用适配者类QuickSortClass的排序方法
        }

        public int Search(int[] array, int key) 
        {
            return searchObj.BinarySearch(array, key); //调用适配者类BinarySearchClass的查找方法
        }
    }
}
