namespace APBD3;

public class LiquidContainer : Container, IHazardNotifier
{
    public static int Licznik; 
    public LiquidContainer(double weight, double height, double depth, double maxWeigth) : base(weight, height, depth, maxWeigth)
    {
        GenerateNumber();
    }
    
    public void GenerateNumber()
    {
        Number = $"KON-L-{Licznik++}";
    }

    public override void Load(Cargo loadedCargo)
    {
        if (loadedCargo.CargoType == Cargo.Type.Liquid)
        {

            base.Load(loadedCargo);
            bool dangerous = loadedCargo.IsDangerous;

            if (dangerous)
            {
                if (GetCargoWeight() > MaxWeight * 0.5)
                {
                    NotifyHazard(GetNumber(),"Error: Dangerous operation");
                    base.SetCargoWeight(MaxWeight * 0.5);
                }
            }
            else
            {
                if (GetCargoWeight() > MaxWeight * 0.9)
                {
                    NotifyHazard(GetNumber(),"Error: Dangerous operation");
                    base.SetCargoWeight(MaxWeight * 0.9);
                }
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