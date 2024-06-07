
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    [SerializeField] protected List<Animal> animals = new();

    private void Start()
    {
        this.AddAnimalsToList();
        this.MakeAnimalsDoSomething();
    }

    protected void AddAnimalsToList()
    {
        foreach (Transform child in transform)
        {
            Animal animal = child.GetComponent<Animal>();
            this.animals.Add(animal);
        }
    }

    protected void MakeAnimalsDoSomething()
    {
        foreach (var item in animals)
        {
            MakeAnimalDoSomething(item);
        }
    }

    protected void MakeAnimalDoSomething(Animal item)
    {
        string info = item.GetInfo();
        Debug.Log(info);
    }
}
