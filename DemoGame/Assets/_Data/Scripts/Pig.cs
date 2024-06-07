using UnityEngine;

public class Pig : FourLegAnimal
{
    public override string GetName()
    {
        return "Pepa";
    }

    public override string MakeSound()
    {
        return "Ec ec";
    }

    public override bool IsHasFur()
    {
        return false;
    }
}
