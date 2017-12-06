namespace Adapter
{
    class QuickSortClass 
    {
	    public int[] QuickSort(int[] array) 
        {
		    Sort(array,0,array.Length - 1);
		    return array;
	    }

        public void Sort(int[] array, int p, int r) 
        {
		    int q = 0;
		    if (p < r) 
            {
			    q = Partition(array,p,r);
			    Sort(array,p,q - 1);
                Sort(array,q + 1,r);
		    }
	    }

	    public int Partition(int[] a, int p, int r) 
        {
		    int x = a[r];
		    int j = p - 1;
		    for (int i = p;i <= r - 1;i++) 
            {
			    if (a[i] <= x) 
                {
				    j++;
				    Swap(a,j,i);
			    }
		    }
		    Swap(a,j + 1,r);
		    return j + 1;	
	    }

	    public void Swap(int[] a, int i, int j) 
        {   
            int t = a[i];   
            a[i] = a[j];   
            a[j] = t;   
	    }
    }
}
