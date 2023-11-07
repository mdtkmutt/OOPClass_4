public class Type
{
    private string _name;
    private int _year;

    public Type(string name, int year)
    {
        this._name = name;
        this._year = year;
    }

    public string GetName()
    {
        return this._name;
    }

    public int GetYear()
    {
        return this._year;
    }
}