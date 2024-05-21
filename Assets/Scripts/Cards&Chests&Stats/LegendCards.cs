using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;

public class LegendCards : MonoBehaviour
{

    public int min;
    public int max;
    public GameObject Card;
    public Text amt;
    public AudioClip newLegendSfx;
    
    // Start is called before the first frame update
    void Start()
    {
        SoundManager . Instance . PlaySound (newLegendSfx);
        string classTag = Card.gameObject.tag;
        HandleClassTags (classTag);

    }
    public void HandleClassTags ( string tag )
    {
        switch ( tag )
        {

            case "Cleric":
                int shards1 =  GameManager.shardBoost + Random . Range (min , max) ;
                GameManager . shardBoost -= 5;
                GameManager . HireCleric += shards1;
                amt . text = "X" + shards1;
                Destroy (Card , 1f);
                break;
            case "Wizard":
                int shards2 = GameManager.shardBoost + Random . Range (min , max);
                GameManager . HireWizard += shards2;
                GameManager . shardBoost -= 5;
                amt . text = "X" + shards2;
                Destroy (Card , 1f);
                break;
            case "Monk":
                int shards3 =  Random . Range (min , max);
                GameManager . HireMonk += shards3;
 
                amt . text = "X" + shards3;
                Destroy (Card , 1f);
                break;
            case "Druid":
                int shards4 = GameManager.shardBoost + Random . Range (min , max);
                GameManager . HireDruid += shards4;
                GameManager . shardBoost -= 5;
                amt . text = "X" + shards4;
                Destroy (Card , 1f);
                break;
            case "Alchemist":
                int shards5 = Random . Range (min , max);
                GameManager . HireAlchemist += shards5;
          
                amt . text = "X" + shards5;
                Destroy (Card , 1f);
                break;
            case "Rogue":
                int shards6 = GameManager.shardBoost  + Random . Range (min , max);
                GameManager . HireRogue += shards6;
                GameManager . shardBoost -= 5;
                amt . text = "X" + shards6;
                Destroy (Card , 1f);
                break;
            case "Paladin":

                int shards7 = Random . Range (min , max);
                GameManager . HirePaladin += shards7;
                amt . text = "X" + shards7;
                Destroy (Card , 1f);
                break;
            case "Necromancer":

                int shards8 = Random . Range (min , max);
                GameManager . HireNecromancer += shards8;
                amt . text = "X" + shards8;
                Destroy (Card , 1f);
                break;
            case "PlagueDoctor":

                int shards9 = Random . Range (min , max);
                GameManager . HirePlague += shards9;
              
                amt . text = "X" + shards9;
                Destroy (Card , 1f);
                break;
            case "SpiritMaster":

                int shards0 = Random . Range (min , max);
                GameManager . HireMaster += shards0;
                amt . text = "X" + shards0;
                Destroy (Card , 1f);
                break;
            case "Merchant":

                int shardsa = Random . Range (min , max);
                GameManager . HireMerchant += shardsa;
              
                amt . text = "X" + shardsa;
                Destroy (Card , 1f);
                break;
            case "Candle":

                int shardss = Random . Range (min , max);
                GameManager . HireCandle += shardss;
             
                amt . text = "X" + shardss;
                Destroy (Card , 1f);
                break;
            case "Bard":

                int shardsb = Random . Range (min , max);
                GameManager . HireBard += shardsb;
         
                amt . text = "X" + shardsb;
                Destroy (Card , 1f);
                break;
            case "FortNight":

                int shardsf = GameManager.shardBoost + Random . Range (min , max);
                GameManager . HireFortnight += shardsf;
                GameManager . shardBoost -= 5;
                amt . text = "X" + shardsf;
                Destroy (Card , 1f);
                break;
            case "Puppeteer":

                int shardsw =  Random . Range (min , max);
                GameManager . HirePuppeteer += shardsw;
              
                amt . text = "X" + shardsw;
                Destroy (Card , 1f);
                break;
            case "Gold":
                int amount = Random.Range(min,max);
                GameManager . soulFire += amount;
                amt . text = "+" + amount;
                Destroy (Card , 1f);
                break;
            default:
                Debug . Log ("Didn't Contain tag");
                break;
        }
    }
    // Update is called once per frame

 


}
