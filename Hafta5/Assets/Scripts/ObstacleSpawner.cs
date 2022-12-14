using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    public GameManager gameManager;
    public Obstacle[] obstaclePrefabs;
    public float spawnRatePerSecond;

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private void Update()
    {
        if (gameManager.isGameOver)
        {
            StopAllCoroutines();
        }
    }

    private IEnumerator SpawnRoutine()
    {
        var waitTime = 1f / spawnRatePerSecond;
        while (true)
        {
            yield return new WaitForSeconds(waitTime);

            SpawnRandomObstacle();
        }
    }

    private void SpawnRandomObstacle()
    {
        var randomObstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        var randomObstaclePrefab = obstaclePrefabs[randomObstacleIndex];
        Instantiate(randomObstaclePrefab,transform.position,Quaternion.identity,transform);
    }
}