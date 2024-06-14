
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    [SerializeField] protected bool showLog = true;
    [SerializeField] protected List<Transform> defaultAnimals = new();
    [SerializeField] protected List<Animal> animals = new();
    public List<Animal> Animals => animals;

    private void Start()
    {
        long startTime = UnixTimeStamp.GetUnixTimeMicro();
        Debug.Log("================StartTime: " + startTime);
        LoadDefaultAnimals();
        CreateRandomAnimals();

        this.AddAnimalsToList();
        this.MakeAnimalsDoSomething();

        long nowTime = UnixTimeStamp.GetUnixTimeMicro();
        Debug.Log("================nowTime: " + nowTime);

        float timeDiff = UnixTimeStamp.GetTimeDiffNow(startTime);
        Debug.Log("================timeDiff: " + timeDiff);
    }

    private void CreateRandomAnimals()
    {
        int createCount = 20000;
        for (int i = 0; i < createCount; i++)
        {
            CreateRandomAnimal();
        }
    }

    private void CreateRandomAnimal()
    {
        Transform randomChild = GetRandomFromDefault();

        Transform newChild = GameObject.Instantiate(randomChild);
        newChild.transform.parent = transform;
    }

    private Transform GetRandomFromDefault()
    {
        int randomIndex = Random.Range(0, defaultAnimals.Count);

        return defaultAnimals[randomIndex];
    }

    private void LoadDefaultAnimals()
    {
        foreach (Transform child in transform)
        {
            defaultAnimals.Add(child);
        }
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

    public void MakeAnimalDoSomething(Animal item)
    {
        string info = item.GetInfo();
        if (showLog) Debug.Log(info);
    }





}
