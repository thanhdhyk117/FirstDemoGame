using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : FourLegAnimal
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override string MakeSound()
    {
        string sound = ("meow meow");
        return sound;
    }

    void CatchRat()
    {

    }
}
