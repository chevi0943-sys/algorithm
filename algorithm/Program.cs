#region 1
/*static int[] fun(int[] arr)
{
    int  sum = 0, max = arr[0], iStart = 0, iEnd = 0, imaxS = 0, imaxE = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];        
        if (sum > max)
        {
            max = sum;
            iEnd = i;
            imaxE = i;
            imaxS = iStart;
        }

        if (sum < 0)
        {
            iStart = i + 1;
            iEnd = i + 1;
            sum = 0;
        }
    }
    return [imaxS, imaxE];
}

int[] arr = [-5, -2, -10];
int[] arr2 = fun(arr);
for (int i = 0; i < 2; i++)
{
    Console.WriteLine(arr2[i]);
}*/
#endregion
#region 2
/*class Obj
{
    public int val { get; set; }
    public int time { get; set; }

    public Obj(int val,int time) 
    { 
        this.val = val;
        this.time = time;
    }

}
class B
{
    private Obj[] arr;
    private int timer;
    private int sett;
    private int timeSet;

    public B()
    {
        arr=new Obj[10];
        timer = 0;
        sett = 0;
        timeSet = 0;

    }
    
    public void Set(int key,int val)
    {
        if (arr[key] == null)
        {
            arr[key] = new Obj(val, ++timer);
        }
        else
        {
            arr[key].val = val;
            arr[key].time = ++timer;
        }
    }
    public int Get(int key)
    {
        return arr[key].time > timeSet ? arr[key].val : sett;
    }

    public void setAll(int val)
    {
        sett = val;
        timeSet = ++timer;
    }
}*/
#endregion
#region 3
/*int ex3(LinkedList<int> list)
{
    if (list == null || list.Count == 0) return 0;

    int[] arr = new int[list.Count];
    list.CopyTo(arr, 0);
    List<int> tails = new List<int>();

    for (int i = 0; i < arr.Length; i++)
    {
        int pos = BinarySearch(tails, arr[i]);
        if (pos == tails.Count)
            tails.Add(arr[i]);
        else
            tails[pos] = arr[i];
    }

    return arr.Length - tails.Count;
}

int BinarySearch(List<int> tails, int x)
{
    int low = 0, high = tails.Count;
    while (low < high)
    {
        int mid = low + (high - low) / 2;
        if (tails[mid] <= x)
            low = mid + 1;
        else
            high = mid;
    }
    return low;
}
*/
#endregion
#region 4
/*static int fun4(int[] arr, int x)
{
    if (arr.Length == 0)
        return 0;
    if (arr.Length == 1)
        return x == arr[0] ? 1 : 0;
    int sum = 0, start = 0, end = 1, res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
        while (sum > x && start <= i)
        {

            sum -= arr[start];
            start++;
            end = i;

        }
        if (sum == x)
        {
            res++;
            sum-=arr[start];
            start++;
            end = i;
        }

    }
    sum = 0;

    return res;
}

int[] arr = [3, 7, 2, 1, 3, 1, 1,0, 2, 2, 5, 1, 1, 1, 1, 1, 1];
Console.WriteLine(fun4(arr, 5));*/
#endregion
#region 5
/*static int func5(int N,int T,int S)
{
    return Math.Max(N - S, N - T) + 1;
}*/
#endregion





