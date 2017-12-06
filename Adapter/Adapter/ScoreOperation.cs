namespace Adapter
{
    interface ScoreOperation 
    {
	    int[] Sort(int[] array); //成绩排序
        int Search(int[] array, int key); //成绩查找
    }
}