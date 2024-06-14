using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SortingAnimals : MonoBehaviour
{
    [SerializeField] protected AnimalManager animalManager;
    [SerializeField] protected List<Animal> sortByWeight = new();

    private void Start()
    {
        SortAnimalsByWeight();
    }

    private void SortAnimalsByWeight()
    {
        if (animalManager.Animals.Count == 0)
        {
            Invoke(nameof(this.SortAnimalsByWeight), 1);
            return;
        }

        this.sortByWeight = new(animalManager.Animals); //Clone
        //MergeSort
        MergeSort(sortByWeight, 0, sortByWeight.Count - 1);

        foreach (var item in sortByWeight)
        {
            animalManager.MakeAnimalDoSomething(item);
        }
    }
    private void MergeSort(List<Animal> arrAnimals, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(arrAnimals, left, middle);
            MergeSort(arrAnimals, middle + 1, right);

            Merge(arrAnimals, left, middle, right);
        }
    }

    private void Merge(List<Animal> arrAnimals, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        Animal[] leftAnimalArray = new Animal[n1];
        Animal[] rightAnimalArray = new Animal[n2];

        for (int i = 0; i < n1; i++)
        {
            leftAnimalArray[i] = arrAnimals[left + i];
        }

        for (int i = 0; i < n2; i++)
        {
            rightAnimalArray[i] = arrAnimals[middle + 1 + i];
        }

        int iLeft = 0, iRight = 0;
        int k = left;

        while (iLeft < n1 && iRight < n2)
        {
            if (leftAnimalArray[iLeft].GetWeightAnimal() <= rightAnimalArray[iRight].GetWeightAnimal())
            {
                arrAnimals[k] = leftAnimalArray[iLeft];
                iLeft++;
            }
            else
            {
                arrAnimals[k] = rightAnimalArray[iRight];
                iRight++;
            }
            k++;
        }

        while (iLeft < n1)
        {
            arrAnimals[k] = leftAnimalArray[iLeft];
            iLeft++;
            k++;
        }

        while (iRight < n2)
        {
            arrAnimals[k] = rightAnimalArray[iRight];
            iRight++;
            k++;
        }
    }
}
