using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject[] enemyObjs;
    //public GameObject[] itemObjs;
    public Transform[] spawnPoints;

    public float maxEnemydelay;
    public float curEnemydelay;
   // public float maxItemdelay;
   // public float curItemdelay;

    void Update()
    {
       // curItemdelay += Time.deltaTime;
        curEnemydelay += Time.deltaTime;

      /*  if (curItemdelay > maxItemdelay)
        {
            SpawnItem();
            maxItemdelay = Random.Range(0.5f, 3f);
            curItemdelay = 0;
        }*/
        if (curEnemydelay > maxEnemydelay)
        {
            SpawnEnemy();
            maxEnemydelay = Random.Range(0.5f, 3f);
            curEnemydelay = 0;
        }
    }
    void SpawnEnemy()
    {
        int ranEnemy = Random.Range(0, 5);
        int ranPoint = Random.Range(0, 3);
        Instantiate(enemyObjs[ranEnemy],
                    spawnPoints[ranPoint].position,
                    spawnPoints[ranPoint].rotation);
    }
   /* void SpawnItem()
    {
        int ranItem = Random.Range(0, 5);
        int ranPoint = Random.Range(0, 3);
        Instantiate(itemObjs[ranItem],
                    spawnPoints[ranPoint].position,
                    spawnPoints[ranPoint].rotation);
    }*/
}
