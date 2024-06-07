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
}
