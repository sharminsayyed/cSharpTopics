public class Car
{
    private string[] _brands = new string[] { "bmw", "skoda", "honda" };
    private string[] _names = new string[] { "first", "second", "third" };

    // indexers - public 
    // with the help of indexers we can access aand set the value to a particular ele in array or strings
    public string this[int ind]
    {
        set
        {
            _brands[ind] = value;
        }
        get { return _brands[ind]; }

    }

    // indexers overloading 
    public string this[string  name]
    {
        set
        {
            _brands[Array.IndexOf(_names, name)] = value;
        }
        get { return _brands[Array.IndexOf(_names, name)]; }

    }

}