using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyMax;
    public float proximityDistance = 10f;
    private bool hasSpawned = false;


    void SpawnEnemies()
    {
        {
            for (int i = 0; i < enemyMax; i++)
            {
                GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);

            }

        }
    }

    void Update()
    {
        // Check if the player is close and spawn enemies only once
        if (!hasSpawned && IsPlayerClose())
        {
            SpawnEnemies();
            hasSpawned = true;
        }
    }

    bool IsPlayerClose()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);
            return distance < proximityDistance;
        }
        return false;
    }

}

