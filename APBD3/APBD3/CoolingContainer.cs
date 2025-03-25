namespace APBD3;

public class CoolingContainer : Container
{
    public static int Licznik;
    public string Type ="";
    public double Temperature;
    
    public CoolingContainer(int weight, int height, int depth,  int maxWeight, double temperature) : base(weight, height, depth, maxWeight)
    {
        Temperature = temperature;
        GenerateSerialNumber();
    }
    
    public void GenerateSerialNumber()
    {
        Number = $"KON-C-{Licznik++}";
    }

    public override void Load(Cargo loadedCargo)
    {
        if (loadedCargo.CargoType == Cargo.Type.Cool)
        {
            if (Temperature < loadedCargo.RequiredTemperature)
            {
                Console.WriteLine("Wrong cargo type");
                return;
            }
            
            base.Load(loadedCargo);
            Type = loadedCargo.Name;
        }
        else
        {
            Console.WriteLine("Wrong cargo type");
        }

    }
}