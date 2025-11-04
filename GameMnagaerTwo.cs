using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTwo : MonoBehaviour
{
    public GameObject enemyTwoPrefab;
    public GameObject player; 

    void Start()
    {
        InvokeRepeating("CreateEnemyTwo", 2, 3);
    }

    void CreateEnemyTwo()
    {
        if (player != null)
        {
            // Spawn at the height of the player
            Vector3 spawnPosition = new Vector3(player.transform.position.x, 9f, 0f);
            Instantiate(enemyTwoPrefab, spawnPosition, Quaternion.identity);
        }
    }
}