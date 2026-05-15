using QuickSort;

int[] array = [6, 45, 7, 2, 7, 3, 9, 4, 8, 21, 7, 4, 2, 7, 9, 8];
int[] newArray = QuickSort.QuickSort.Sort(array);

foreach(int num in newArray){
    Console.WriteLine(num.ToString());
}
