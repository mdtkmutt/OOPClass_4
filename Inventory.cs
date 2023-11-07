public class Inventory
{
    private Guitar[] _guitars;
    private Medolin[] _medolins;

    public Inventory(Guitar[] guitars)
    {
        this._guitars = guitars;
    }

    public Inventory(Medolin[] medolins)
    {
        this._medolins = medolins;
    }


    // Function Overlading
    public Guitar GetGuitar(string serialNumber)
    {
        foreach (Guitar guitar in this._guitars)
        {
            if (guitar.GetSerialNumber().Equals(serialNumber))
            {
                return guitar;
            }
        }

        return null;
    }

    public Guitar GetGuitar(double price)
    {
        foreach (Guitar guitar in this._guitars)
        {
            if (guitar.GetPrice().Equals(price))
            {
                return guitar;
            }
        }

        return null;
    }

    public Guitar Search(Guitar searchGuitar)
    {
        foreach (Guitar guitar in this._guitars)
        {
            string serialNumber = searchGuitar.GetSerialNumber();
            double price = searchGuitar.GetPrice();

            if (guitar.GetSerialNumber().Equals(serialNumber) &&
               guitar.GetPrice().Equals(price))
            {
                return guitar;
            }
        }
        return null;
    }

    // Medolin 
    public Medolin GetMedolin(string serialNumber)
    {
        foreach (Medolin medolin in this._medolins)
        {
            if (medolin.GetSerialNumber().Equals(serialNumber))
            {
                return medolin;
            }
        }

        return null;
    }

    public Medolin GetMedolin(double price)
    {
        foreach (Medolin medolin in this._medolins)
        {
            if (medolin.GetPrice().Equals(price))
            {
                return medolin;
            }
        }

        return null;
    }

    public Medolin Search(Medolin searchMedolin)
    {
        foreach (Medolin medolin in this._medolins)
        {
            string serialNumber = searchMedolin.GetSerialNumber();
            double price = searchMedolin.GetPrice();

            if (medolin.GetSerialNumber().Equals(serialNumber) &&
               medolin.GetPrice().Equals(price))
            {
                return medolin;
            }
        }
        return null;
    }
}