namespace APBD3;

public class ContainerShip(double maxSpeed, int maxContainersCount, double maxTotalWeight)
{
    private List<Container> Containers { get; set; } = [];
    private double MaxSpeed { get; set; } = maxSpeed;
    private int MaxContainersCount { get; set; } = maxContainersCount;
    private double MaxTotalWeight { get; set; } = maxTotalWeight;


    public void Load(Container container)
    {
        if (Containers.Count >= MaxContainersCount)
        {
            throw new OverfillException("Too many containers.");
        }

        if (GetTotalWeight() > MaxTotalWeight)
        {
            throw new OverfillException("Too much weight.");
        }

        Containers.Add(container);
    }
    
    
    public void Drop(string containerId)
    {
        for (var index = 0; index < Containers.Count; index++)
        {
            if (Containers[index].GetNumber() == containerId)
            {
                Containers.Remove(Containers[index]);
            }
        }
    }

    public void Replace(Container container1, Container container2)
    {
        bool exist = false;
        int tempIndex=0; 
        
        for (var index = 0; index < Containers.Count; index++)
        {
            if (Containers[index].GetNumber() == container2.GetNumber())
            {
             exist = true;
             tempIndex = index;
            }
        }
        
        
        for (var index = 0; index < Containers.Count; index++)
        {
            if (Containers[index].GetNumber() == container1.GetNumber())
            {
                Containers[index] = container2;
            }
            
        }

        if (exist)
        {
            Containers[tempIndex] = container1;
        }
    }

    public void Move(ContainerShip containerShip, string containerId)
    {
        for (var index = 0; index < Containers.Count; index++)
        {
            if (Containers[index].GetNumber()== containerId)
            {
                containerShip.Load(Containers[index]);
                Containers.Remove(Containers[index]);
            }
        }
    }

    public double GetTotalWeight()
    {
        double totalWeight = 0;
        for (int i = 0; i < Containers.Count(); i++)
        {
            totalWeight += Containers[i].GetTotalWeight();
        }

        return totalWeight / 1000;
    }

    public override string ToString()
    {
        string containersToString = "";

        for (var index = 0; index < Containers.Count; index++)
        {
            if (index == Containers.Count - 1)
            {
                containersToString += Containers[index];
            }
            else
            {
                containersToString += Containers[index] + ", ";
            }
        }

        return "\n Containers on board: " + containersToString +
               "\n Max speed: " + MaxSpeed + 
               "\n Max containers: " + MaxContainersCount +
               "\n Max total weight: " + GetTotalWeight();
    }
}