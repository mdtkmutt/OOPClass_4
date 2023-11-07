public class Medolin
{
    private string _serialNumber;
    private double _price;
    private MedolinSpec _spec;

    public Medolin(string serialNumber, double price, MedolinSpec spec)
    {
        this._serialNumber = serialNumber;
        this._price = price;
        this._spec = spec;
    }

    public string GetSerialNumber()
    {
        return this._serialNumber;
    }

    public double GetPrice()
    {
        return this._price;
    }

    public void SetPrice(double newPrice)
    {
        this._price = newPrice;
    }

    public MedolinSpec GetMedolinSpec()
    {
        return this._spec;
    }

}