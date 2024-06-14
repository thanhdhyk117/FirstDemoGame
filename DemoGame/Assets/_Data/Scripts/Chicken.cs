using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Bird
{
    public override string GetName()
    {
        return "Chick";
    }

    public override string MakeSound()
    {
        return "Of os o";
    }
    protected override void RandomWeight()
    {
        this.weight = Random.Range(1f, 3f);
    }
}
