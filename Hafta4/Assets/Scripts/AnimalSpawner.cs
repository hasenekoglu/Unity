using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] animals;
    [SerializeField] private float xRange;
    [SerializeField] private float yPos;
    [SerializeField] private float zPos;
    [SerializeField] private float spawnRate;
    [SerializeField] private float minSpawnRate;


    private void Start()
    {
        StartCoroutine(SpawnAnimals());
    }

    private IEnumerator SpawnAnimals()
    {
        int counter = 0;
        while (true)
        {
            counter++;
            if (counter % 2 == 0 && spawnRate > minSpawnRate)
            {
                spawnRate = spawnRate - (spawnRate / 5);
            }

            int randomNumber = Random.Range(0, animals.Length);
            Instantiate(animals[randomNumber], RandomSpawnPosition(), animals[randomNumber].transform.rotation);
            yield return new WaitForSeconds(spawnRate);
        }
    }

    private Vector3 RandomSpawnPosition()
    {
        float randomXValue = Random.Range(-xRange, xRange);
        return new Vector3(randomXValue, yPos, zPos);
    }
}