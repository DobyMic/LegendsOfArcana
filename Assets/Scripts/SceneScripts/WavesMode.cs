using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;
using UnityEngine . SceneManagement; 

public class EnemyToSpawns
{

    public GameObject item;
    public float spawnRate;
    [HideInInspector] public float minSpawnProb, maxSpawnProb;
}
public class WavesMode : MonoBehaviour
{
    public AudioClip rewardSfx;
    public AudioClip newWaveSfx;

    public float spawnTimer = 20f;
   

    public ItemToSpawn[] EnemyToSpawns;


    public int rewardRounds;
    public int waveRound = 1;

    public Text waveRoundText;

    public Text timerText;

    public GameObject boss;

    public float roundTIME;

    public int finalwave;

    public bool enchantReward;

    public GameObject bean;

    void GenerateEnemy ( )
    {
        for ( int i = 0 ; i < EnemyToSpawns . Length ; i++ )
        {
            if ( i == 0 )
            {
                EnemyToSpawns [ i ] . minSpawnProb = 0;
                EnemyToSpawns [ i ] . maxSpawnProb = EnemyToSpawns [ i ] . spawnRate - 1;
            }
            else
            {
                EnemyToSpawns [ i ] . minSpawnProb = EnemyToSpawns [ i - 1 ] . maxSpawnProb + 1;
                EnemyToSpawns [ i ] . maxSpawnProb = EnemyToSpawns [ i ] . minSpawnProb + EnemyToSpawns [ i ] . spawnRate - 1;
            }


        }
        float randomNum = Random.Range(0, 10);
 
        for ( int i = 0 ; i < EnemyToSpawns . Length ; i++ )
        {
       
            if ( randomNum >= EnemyToSpawns [ i ] . minSpawnProb && randomNum <= EnemyToSpawns [ i ] . maxSpawnProb )
            {
           

                Instantiate (EnemyToSpawns [ i ] .item, new Vector3(Random.Range(0,8), Random . Range (-3 , 3),0) , Quaternion . identity);

                break;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        timerText . text = spawnTimer . ToString ("F0");
        int roundcount = waveRound;
        waveRoundText . text = "Wave: " + roundcount . ToString () + "/" + finalwave;

        spawnTimer -= Time . deltaTime;
        if ( spawnTimer <= 0 )
        {
            waveRound += 1;
            Spawn (waveRound);
            SoundManager . Instance . PlaySound (newWaveSfx);
            spawnTimer = roundTIME;
          
        }

        
            


    }

    public void Spawn ( int amount )
    {

        if ( waveRound < finalwave )
        {
        
            for ( int i = 0 ; i < amount ; i++ )
            {
            
                GenerateEnemy ();
            }
        }
        else
        {
            Instantiate (boss , gameObject . transform . position , Quaternion . identity);
            roundTIME = Mathf . Infinity;
            spawnTimer = roundTIME;
            Instantiate (bean , new Vector2(9,0) , Quaternion . identity);

        }

  


        if(waveRound % rewardRounds == 0)
        {
            if ( enchantReward == true )
            {
                GameManager . enchantChest += 1 + (int)waveRound / 5 * 2;
                SoundManager . Instance . PlaySound (rewardSfx);
            }
            else
            {
                float reward = Random.Range(1,4);
                SoundManager . Instance . PlaySound (rewardSfx);

                switch ( reward )
                {

                    case 1:
                        GameManager . soulFire += Random . Range (1 , 5);
                        Debug . Log ("Reward");
                      break;

                    case 2:
                        GameManager .commonChest += Random . Range (1 , 2);
                        Debug . Log ("Reward");
                        break;
                    case 3:
                        GameManager .HireWizard  += Random . Range (5 , 10);
                        Debug . Log ("Reward");
                        break;
                    case 4:
                        GameManager .HireCleric += Random . Range (5 , 10);
                        Debug . Log ("Reward");
                        break;

                }
            }


           


            
         
        }

       
    }
}
