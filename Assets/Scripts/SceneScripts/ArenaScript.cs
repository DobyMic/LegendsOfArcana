using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyToSpawn
{

    public GameObject item;
    public float spawnRate;
    [HideInInspector] public float minSpawnProb, maxSpawnProb;
}
public class ArenaScript : MonoBehaviour
{

    public float spawnTimer = 1f;

    public float rewardTime = 10f;

    public ItemToSpawn[] EnemyToSpawn;

 


         
    void GenerateEnemy()
    {
        for (int i = 0; i < EnemyToSpawn.Length; i++)
        {
            if (i == 0)
            {
                EnemyToSpawn[i].minSpawnProb = 0;
                EnemyToSpawn[i].maxSpawnProb = EnemyToSpawn[i].spawnRate - 1;
            }
            else
            {
                EnemyToSpawn[i].minSpawnProb = EnemyToSpawn[i - 1].maxSpawnProb + 1;
                EnemyToSpawn[i].maxSpawnProb = EnemyToSpawn[i].minSpawnProb + EnemyToSpawn[i].spawnRate - 1;
            }
        }
    }

        
    void Update()
    {
     
        if(rewardTime <= 0f)
        {
            rewardTime = 12;
            GameManager . KingChest += 1;
        }


        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            GenerateEnemy();

            float randomNum = Random.Range(0, 10);

            for (int i = 0; i < EnemyToSpawn.Length; i++)
            {
                if (randomNum >= EnemyToSpawn[i].minSpawnProb && randomNum <= EnemyToSpawn[i].maxSpawnProb)
                {
                    GameObject spawned = EnemyToSpawn[i].item;
                    
                    Instantiate(spawned, new Vector3 (Random . Range (0 , 8) , Random . Range (-3 , 3) , 0) , Quaternion.identity);
                    break;
                }
            }


            spawnTimer = 0.75f;
         
        
            

            
        }
     
        
        

    }


 


    // Update is called once per frame




}
