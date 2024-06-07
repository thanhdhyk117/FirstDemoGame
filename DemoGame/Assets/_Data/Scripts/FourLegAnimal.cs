using UnityEngine;

public abstract class FourLegAnimal : Animal
{
    public virtual bool IsHasFur()
    {
        return true;
    }

    public override int CountLeg()
    {
        return 4;
    }
}
