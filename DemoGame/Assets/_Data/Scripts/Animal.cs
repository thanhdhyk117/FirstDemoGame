using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected int legCount = 0;
    protected float weight = 0;

    private void Awake()
    {
        this.RandomWeight();
    }

    protected virtual void RandomWeight()
    {
        this.weight = Random.Range(1f, 30f);
    }

    public abstract string MakeSound();
    public abstract string GetName();
    public virtual string GetInfo()
    {
        string info = "";
        string petName = this.GetName();
        string petSound = this.MakeSound();
        float weightValue = this.GetWeightAnimal();

        info = petName + " make sound: " + petSound + " and has " + CountLeg() + " leg." +
               "\n/weight: " + weightValue;
        return info;
    }

    public virtual float GetWeightAnimal()
    {
        return this.weight;
    }
    public virtual int CountLeg()
    {
        return legCount;
    }
}
