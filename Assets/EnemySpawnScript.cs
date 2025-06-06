using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour {

    public GameObject enemyPrefabLeft;
    public GameObject enemyPrefabRight;
    public Transform EnemySpawnPointLeft;
    public Transform EnemySpawnPointRight;

    public bool commence = false;
    public float enemyWindow = .05f;
    float timer;
	
	// Update is called once per frame
	void Update ()
    {
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        float totalWindow = 5;
        timer = Mathf.Repeat(Time.time, totalWindow);
        if (commence == true)
        {
            if (timer > 4 && timer < 4 + enemyWindow)
                SpawnEnemyLeft();
            else if (timer > 1.5 && timer < 1.5 + enemyWindow)
                SpawnEnemyRight();
            else
            {
                if (enemyWindow < .5)
                    enemyWindow += .0001f;
                if (enemyWindow >= .5 && enemyWindow < 1)
                    enemyWindow += .001f;
                if (enemyWindow >= 1 && enemyWindow < 5)
                    enemyWindow += .01f;
                if (enemyWindow >= 5 && enemyWindow < 10)
                    enemyWindow += .1f;
                if (enemyWindow >= 10)
                    enemyWindow += 1;
            }
        }
    }

    private void SpawnEnemyLeft()
    {
        GameObject Enemy = Instantiate(enemyPrefabLeft, EnemySpawnPointLeft.position, Quaternion.identity);
    }

    private void SpawnEnemyRight()
    {
        GameObject Enemy = Instantiate(enemyPrefabRight, EnemySpawnPointRight.position, Quaternion.identity);
    }
}
