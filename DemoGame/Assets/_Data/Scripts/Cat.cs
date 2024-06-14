using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : FourLegAnimal
{
    public override string GetName()
    {
        return "Tom";
    }

    // Start is called before the first frame update
    public override string MakeSound()
    {
        string sound = ("meow meow");
        return sound;
    }

    void CatchRat()
    {

    }

    protected override void RandomWeight()
    {
        this.weight = Random.Range(1f, 10f);
    }
}
