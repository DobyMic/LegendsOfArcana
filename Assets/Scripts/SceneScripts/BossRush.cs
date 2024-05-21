using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System . Serializable]
public class BossToSpawn
{

    public GameObject item;
    public float spawnRate;
    [HideInInspector] public float minSpawnProb, maxSpawnProb;
}

public class BossRush : MonoBehaviour
{

    public ItemToSpawn[] BossToSpawn;

    public GameObject posItem;

    
    // Start is called before the first frame update
    void Start()
    {
        for ( int i = 0 ; i < BossToSpawn . Length ; i++ )
        {
            if ( i == 0 )
            {
                BossToSpawn [ i ] . minSpawnProb = 0;
                BossToSpawn [ i ] . maxSpawnProb = BossToSpawn [ i ] . spawnRate - 1;
            }
            else
            {
                BossToSpawn [ i ] . minSpawnProb = BossToSpawn [ i - 1 ] . maxSpawnProb + 1;
                BossToSpawn [ i ] . maxSpawnProb = BossToSpawn [ i ] . minSpawnProb + BossToSpawn [ i ] . spawnRate - 1;
            }
        }

        Spawn ();

  
    }

    void Spawn()
    {
        float randomNum = Random.Range(0,5);

        for ( int i = 0 ; i < BossToSpawn . Length ; i++ )
        {
            if ( randomNum >= BossToSpawn [ i ] . minSpawnProb && randomNum <= BossToSpawn [ i ] . maxSpawnProb )
            {
                GameObject spawned = BossToSpawn[i].item;
                posItem = GameObject. Find ("SpawnPoint");
                Instantiate (spawned , posItem . transform . position , Quaternion . identity);
                break;
            }
        }
    }

   

   
}
