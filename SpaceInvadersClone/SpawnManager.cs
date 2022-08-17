using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnXRange = 9.0f;
    private float spawnYLow = 1.0f;
    private float spawnYHigh = 3.5f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    private int maxEnemyCount = 20;
    private int currentEnemyCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        if (currentEnemyCount < maxEnemyCount)
        {
            float xPosition = Random.Range(-spawnXRange, spawnXRange);
            float yPosition = Random.Range(spawnYLow, spawnYHigh);
            Vector3 spawnPosition = new Vector3(xPosition, yPosition, 0);

            Instantiate(enemyPrefab, spawnPosition, enemyPrefab.transform.rotation);
            currentEnemyCount++;

        }
    }
}
