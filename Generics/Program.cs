// See https://aka.ms/new-console-template for more information


List<string> cities = new List<string>();
cities.Add("İzmir");
cities.Add("İzmir");
cities.Add("İzmir");
cities.Add("İzmir");
cities.Add("İzmir");
cities.Add("İzmir");
Console.WriteLine(cities.Count);
MyList<string> cities2 = new MyList<string>();
cities2.Add("İzmir");
cities2.Add("İzmir");
cities2.Add("İzmir");
cities2.Add("İzmir");
cities2.Add("İzmir");
cities2.Add("İzmir");
cities2[0] = "İstanbul";
Console.WriteLine(cities2.Count());
Console.WriteLine(cities2[0]);
foreach (var city in cities2.Items)
{
    Console.WriteLine(city);
}


public class MyList<T>
{
    T[] _array;
    T[] _temparray;

    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _temparray = _array;
        _array = new T[_array.Length + 1];
        for(int i=0; i < _temparray.Length; i++)
        {
            _array[i] = _temparray[i];
        }
        _array[_array.Length - 1] = item;
    }

    public int Count()
    {
        return _array.Length;
    }

    public T this[int index]
    {
        get
        {
            return _array[index];
        }
        set
        {
            _array[index] = value;
        }

    }

    public T[] Items
    {
        get { return _array; }
    }
}
