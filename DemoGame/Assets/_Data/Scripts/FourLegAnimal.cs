using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FourLegAnimal : MonoBehaviour
{
    int legCount = 4;
    int tailCount = 1;

    protected abstract string MakeSound();
    void IsHasTeeth()
    {

    }

    void IsHasFur()
    { }
}
