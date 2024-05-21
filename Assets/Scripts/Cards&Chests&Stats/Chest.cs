using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;
[System.Serializable]
public class ItemToSpawn
{

    public GameObject item;
    public float spawnRate;
    [HideInInspector] public float minSpawnProb, maxSpawnProb;
}

public class Chest : MonoBehaviour
{

    public ItemToSpawn[] itemToSpawn;

    public GameObject posItem;

    public GameObject spawned;

    public bool common;
    public bool noble;
    public bool king;
    public bool legends;
    public bool enchant;
    public Text tracker;

    public GameObject particleExplode;
    public AudioClip chestOpenSfx;
    public AudioClip enchantOpenSfx;


    private float chestTimer; // time of last attack

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
       

        animator = GetComponent<Animator> ();
        
        for(int i =0 ; i < itemToSpawn.Length ; i++ )
        {
            if(i == 0)
            {
                itemToSpawn [ i ] . minSpawnProb = 0;
                itemToSpawn [ i ] . maxSpawnProb = itemToSpawn [ i ] . spawnRate - 1;
            }
            else
            {
                itemToSpawn [ i ] .minSpawnProb = itemToSpawn [ i-1 ] . maxSpawnProb + 1;
                itemToSpawn [ i ] . maxSpawnProb = itemToSpawn [ i ] . minSpawnProb + itemToSpawn [ i ] . spawnRate - 1;
            }
        }
    }



    private void Update ( )
    {
        if(noble== true)
        {
            tracker . text = GameManager . NobleChest.ToString();
        }
        if(common == true)
        {
            tracker . text = GameManager . commonChest . ToString ();
        }
        if(king == true)
        {
            tracker . text = GameManager . KingChest. ToString ();
        }
        if(legends == true)
        {
            tracker . text = GameManager . LegendChest . ToString ();
        }
        if(enchant == true)
        {
            tracker . text = GameManager . enchantChest . ToString ();
        }
    }



    void Spawner()
    {
        float randomNum = Random.Range(0,100);

        for(int i = 0 ; i < itemToSpawn.Length ; i++ )
        {
            if(randomNum >= itemToSpawn[i].minSpawnProb && randomNum <= itemToSpawn[i].maxSpawnProb)
            {
                Instantiate (itemToSpawn [ i ] . item , posItem.transform.position, Quaternion.identity);
            
                break;
            }
        }
    }

     
    
    public void BtnDown()
    {
        if(common == true)
        {
            if(GameManager.commonChest >=1)
            {
                SoundManager . Instance . PlaySound (chestOpenSfx);
                OpenFunc ();
                

         
            }
        }
        if ( noble == true )
        {
            if ( GameManager . NobleChest >= 1 )
            {
                SoundManager . Instance . PlaySound (chestOpenSfx);
                OpenFunc ();
            
       
            }
        }
        if ( king == true )
        {
            if ( GameManager . KingChest >= 1 )
            {
                SoundManager . Instance . PlaySound (chestOpenSfx);
                OpenFunc ();
           
            }

        }
        if ( legends == true )
        {
            if ( GameManager . LegendChest >= 1 )
            {
                SoundManager . Instance . PlaySound (chestOpenSfx);
                OpenFunc ();
              
            }

        }
        if ( enchant == true )
        {
            if ( GameManager . enchantChest >= 1 )
            {
                SoundManager . Instance . PlaySound (chestOpenSfx);
                OpenFunc ();

            }

        }
    }


    // Update is called once per frame
    public void OpenFunc()
    {

        
        

        if ( Time . time - chestTimer >= 1f )
        {

            if ( IsOpen () )
            {
                animator . SetTrigger ("close");
                
            }
            else
            {
                animator . SetTrigger ("open");
                chestTimer = Time.time;
                Spawner ();
                if ( legends == true )
                    GameManager . LegendChest -= 1;

                if ( king == true )
                    GameManager . KingChest -= 1;

                if ( common == true )
                    GameManager . commonChest -= 1;

                if ( noble == true )
                    GameManager . NobleChest -= 1;
                if ( enchant == true )
                {

                    GameManager . enchantChest -= 1;
                    Instantiate (particleExplode , transform . position , Quaternion . identity);
                }

                   
            }
         

        }

            

        
      

    }



    bool IsOpen()
    {
        return animator . GetCurrentAnimatorStateInfo (0) . IsName ("ChestOpen");

    }

   


    

}
