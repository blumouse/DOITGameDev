using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMgr : MonoBehaviour
{
    public GameObject[] enemyObjs;
    //public GameObject[] itemObjs;
    public Transform[] spawnPoints;

    public float maxEnemydelay;
    public float curEnemydelay;
    //public float maxItemdelay;
    //public float curItemdelay;


    void Update()
    {
        //curItemdelay += Time.deltaTime;
        curEnemydelay += Time.deltaTime;

        /*if (curItemdelay > maxItemdelay)
        {
            SpawnItem();
            maxItemdelay = Random.Range(0.5f, 3f);
            curItemdelay = 0;
        }*/
        if (curEnemydelay > maxEnemydelay && !BgStop1.bgStoped && !Lifebox.gameover)
        {
            SpawnEnemy();
            maxEnemydelay = Random.Range(2.5f, 4f);
            curEnemydelay = 0;
        }

    }
    void SpawnEnemy()
    {
        int ranEnemy = Random.Range(0, enemyObjs.Length);

        if (ranEnemy == 0)
        {
            Instantiate(enemyObjs[ranEnemy],
                    spawnPoints[2].position,
                    spawnPoints[2].rotation);
        }
        else if (ranEnemy == 1 || ranEnemy == 2)
        {
            Instantiate(enemyObjs[ranEnemy],
                    spawnPoints[2].position,
                    spawnPoints[2].rotation);
        }
        else
        {
            int ranPoint = Random.Range(0, spawnPoints.Length);
            Instantiate(enemyObjs[ranEnemy],
                        spawnPoints[ranPoint].position,
                        spawnPoints[ranPoint].rotation);
        }
        
    }
    /*void SpawnItem()
    {
        int ranItem = Random.Range(0, 5);
        int ranPoint = Random.Range(0, 3);
        Instantiate(itemObjs[ranItem],
                    spawnPoints[ranPoint].position,
                    spawnPoints[ranPoint].rotation);
    }*/
}
