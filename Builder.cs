public class Builder
{
    private string _name;
    private string _gender;
    private int _age;

    public Builder(string name, string gender, int age)
    {
        this._name = name;
        this._gender = gender;
        this._age = age;
    }

    public string GetBuilderName()
    {
        return this._name;
    }

    public string GetGender()
    {
        return this._gender;
    }

    public int GetAge()
    {
        return this._age;
    }
}