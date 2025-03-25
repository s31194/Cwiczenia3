namespace APBD3;

public class GasContainer : Container, IHazardNotifier
{
    public static int Licznik;
    public double Pressure;

    public GasContainer(int weight, int height, int depth, int maxWeight, double pressure) : base(weight, height, depth, maxWeight)
    {
        Pressure = pressure;
        GenerateSerialNumber();
    }


    public void GenerateSerialNumber()
    {
        Number = $"KON-G-{Licznik++}";
    }

    public override void Drop()
    {
        Cargo.Weight *= 0.05;
    }

    public override void Load(Cargo loadedCargo)
    {
        if (loadedCargo.CargoType == Cargo.Type.Gas)
        {
            base.Load(loadedCargo);
            bool dangerous = false;

            if (dangerous)
            {
                NotifyHazard(GetNumber(),"Error: Dangerous operation");
            }
        }
        else
        {
            Console.WriteLine("Wrong cargo type");
        }
    }


    public void NotifyHazard(string containerNumber, string message)
    {
        Console.WriteLine("{0}: {1}", containerNumber, message);
    }
}