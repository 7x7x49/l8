public class Array<T>
{
    public T[] array;

    public Array(int size)
    {
        array = new T[size];
    }
    public void Add(int ind, T item)
    {
        array[ind] = item;
    }
    public void Delete(T item)
    {
        int ind = Array.IndexOf(array, item);
        if (ind > -1)
        {
            T[] newItem = new T[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i == ind) continue;
                newItem[j] = array[i];
                j++;
            }
            array = newItem;
        }
    }
    public T GetElem(int ind)
    {
        return array[ind];
    }
    public int GetLength()
    {
        return array.Length;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Array<int> array_int = new Array<int>(10);
        array_int.Add(9, 34886);
        Array<string> array_string = new Array<string>(4);
        array_string.Add(2, "4");
        Array<double> array_double = new Array<double>(235);
        array_double.Add(233, 0.000000000000000000000003);
        Console.WriteLine(array_int.GetElem(9));
    }
}
