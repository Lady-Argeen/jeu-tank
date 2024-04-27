using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;








public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    //public float spawnInterval = 3f;

    void Start()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }

    private void Update()
    {
        
    }
}
