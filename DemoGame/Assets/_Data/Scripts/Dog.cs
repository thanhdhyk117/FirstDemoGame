using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : FourLegAnimal
{
    public override string GetName()
    {
        return "Dogg";
    }

    public override string MakeSound()
    {
        string sound = ("Gow gow");
        return sound;
    }

    void GuardHouse()
    {

    }
}
