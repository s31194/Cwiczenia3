namespace APBD3;

public class Cargo(string name, Cargo.Type cargoType, double weight, bool isDangerous, double requiredTemperature = 0)
{
    public enum Type
    {
        Liquid,
        Gas,
        Cool,
        None
    }

    public string Name = name;
    public Type CargoType = cargoType;
    public double Weight = weight;
    public bool IsDangerous = isDangerous;
    public double RequiredTemperature = requiredTemperature;
}