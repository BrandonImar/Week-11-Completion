using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTwo : MonoBehaviour
{

    public GameObject enemyTwoPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyTwo", 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(Random.Range(6.5f, -6.5f), 9f, 0), Quaternion.identity);
    }
}
