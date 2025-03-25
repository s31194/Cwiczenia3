namespace APBD3;

abstract
    public class Container(double weight, double height, double depth, double maxWeight)
{
    protected double Weight = weight;
    protected double Height = height;
    protected double ContainerWeight = 0;
    protected double Depth = depth;
    protected string Number = "";
    protected double MaxWeight = maxWeight;
    
    
    protected Cargo Cargo = new Cargo("None", Cargo.Type.None, 0, false); // jeszcze nie wiem po co

    
    public string GetNumber()
    {
        return Number;
    }

    public double GetTotalWeight()
    {
        return Weight + Cargo.Weight;
    }

    public double GetCargoWeight()
    {
        return Cargo.Weight;
    }

    public void SetCargoWeight(double weight)
    {
        Cargo.Weight = weight;
    }


    public virtual void Drop()
    {
        SetCargoWeight(0);
    }

    public virtual void Load(Cargo loadedCargo)
    {
        if (GetCargoWeight() != 0)
        {
            Console.WriteLine("Container is already loaded");
        }

        SetCargoWeight(loadedCargo.Weight);

        if (GetCargoWeight() >= MaxWeight)
        {
            SetCargoWeight(0);
            throw new OverfillException("Weigth exceeds max weight.");
        }

        Cargo = loadedCargo;
    }


    public override string ToString()
    {
        return Number + "[" + Cargo.Name + "]";
    }
}