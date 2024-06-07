using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected int legCount = 0;

    public abstract string MakeSound();
    public abstract string GetName();
    public virtual string GetInfo()
    {
        string info = "";
        string petName = this.GetName();
        string petSound = this.MakeSound();

        info = petName + " make sound: " + petSound + " and has " + CountLeg() + " leg.";
        return info;
    }
    public virtual int CountLeg()
    {
        return legCount;
    }
}
