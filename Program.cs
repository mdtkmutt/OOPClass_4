class Program
{
    static void Main(string[] args)
    {
        SearchGuitar();
        SearchMedolin();
    }

    private static void SearchGuitar()
    {
        Inventory inventory = new Inventory(initializeInventory());

        Guitar guitar = new Guitar("000004", 8254.52, Spec());
        Guitar searchResultGuitar = inventory.Search(guitar);

        if (searchResultGuitar != null)
        {
            PrintGuitarInformation(searchResultGuitar);
        }
        else
        {
            Console.WriteLine("Sorry not found !!");
        }
    }

    private static void SearchMedolin()
    {
        Inventory inventory = new Inventory(initializeMedolinInventory());

        Medolin medolin = new Medolin("000004", 8254.52, MedolinSpec());
        Medolin searchResultMedorin = inventory.Search(medolin);

        if (searchResultMedorin != null)
        {
            PrintMedorinInformation(searchResultMedorin);
        }
        else
        {
            Console.WriteLine("Sorry not found !!");
        }
    }

    private static Wood Wood()
    {
        return new Wood("Alder", "Kittinun Chobtham");
    }

    private static Type Model()
    {
        return new Type("Model s", 2022);
    }

    private static Builder Builder()
    {
        return new Builder("NhongZa", "Male", 32);
    }

    private static GuitarSpec Spec()
    {
        return new GuitarSpec(Program.Builder(), Program.Model(), Program.Wood());
    }

    private static MedolinSpec MedolinSpec()
    {
        return new MedolinSpec(Program.Builder(), Program.Model(), Program.Wood());
    }

    private static void PrintGuitarInformation(Guitar guitar)
    {
        Console.WriteLine("******************************");
        Console.WriteLine("Guitar serial-number : {0}", guitar.GetSerialNumber());
        Console.WriteLine("Guitar Price: {0}", guitar.GetPrice());
        Console.WriteLine("Guitar Builder: {0}", guitar.GetGuitarSpec().GetBuilder());
        Console.WriteLine("Guitar Model: {0}", guitar.GetGuitarSpec().GetModel());
        Console.WriteLine("Guitar Wood: {0}", guitar.GetGuitarSpec().GetWood());
        Console.WriteLine("******************************");
    }

    private static void PrintMedorinInformation(Medolin medolin)
    {
        Console.WriteLine("******************************");
        Console.WriteLine("Medorin serial-number : {0}", medolin.GetSerialNumber());
        Console.WriteLine("Medorin Price: {0}", medolin.GetPrice());
        Console.WriteLine("Medorin Builder: {0}", medolin.GetMedolinSpec().GetBuilder());
        Console.WriteLine("Medorin Model: {0}", medolin.GetMedolinSpec().GetModel());
        Console.WriteLine("Medorin Wood: {0}", medolin.GetMedolinSpec().GetWood());
        Console.WriteLine("******************************");
    }

    private static Guitar[] initializeInventory()
    {
        Guitar[] guitars = { new Guitar("000001", 5000.52, Spec()),
        new Guitar("000002", 7412.52, Spec()),
        new Guitar("000003", 3917.52, Spec()),
        new Guitar("000004", 8254.52, Spec()),
        new Guitar("000005", 1234.52, Spec())
        };

        return guitars;
    }

    private static Medolin[] initializeMedolinInventory()
    {
        Medolin[] medolins = { new Medolin("000001", 5000.52, MedolinSpec()),
        new Medolin("000002", 7412.52, MedolinSpec()),
        new Medolin("000003", 3917.52, MedolinSpec()),
        new Medolin("000004", 8254.52, MedolinSpec()),
        new Medolin("000005", 1234.52, MedolinSpec())
        };

        return medolins;
    }
}