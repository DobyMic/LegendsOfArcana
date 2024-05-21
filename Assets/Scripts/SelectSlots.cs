using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine . UI;

public class SelectSlots : MonoBehaviour, IDropHandler
{

    public GameObject Ranger;
    public GameObject Knight;
    public GameObject Wizard;
    public GameObject Cleric;
    public GameObject Monk;
    public GameObject Druid;
    public GameObject Alchemist;
    public GameObject Rogue;
    public GameObject Paladin;
    public GameObject Necromancer;
    public GameObject Dummy;
    public GameObject Plague;
    public GameObject Master;
    public GameObject Merchant;
    public GameObject Candle;
    public GameObject Fortnight;
    public GameObject Bard;
    public GameObject Puppeteer;

    public GameObject keyLock;

    public GameObject Spawn1;

   

    public GameObject slot;


    public GameObject[] deactivators;
    public GameObject[] allSpawnsCycle;

    public AudioClip lockInSfx;
    public GameObject tutorialObj;

  
   
    public void OnDrop(PointerEventData eventData)
    {


        SoundManager . Instance . PlaySound (lockInSfx);
        
            if (transform.childCount == 0)
            {
                GameObject dropped = eventData.pointerDrag;
                DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
                draggableItem.parentAfterDrag = transform;

                string classTag = draggableItem.gameObject.tag;
                HandleClassTags(classTag);
                keyLock.SetActive(true);
                draggableItem . gameObject . transform . localScale = new Vector3(0.9f,0.9f,0.9f);
                if(GameManager.allForOne == true)
                {

                   for( int i = 0; i < 3 ; i++  )
                   {
                      Spawn1 = Instantiate (new GameObject(), new Vector2 (Random.Range(-7,0),Random.Range(-4,4)) , Quaternion . identity);
                      
                      HandleClassTags (classTag);
                     GameManager . allForOne = false;
                   }

                   foreach(GameObject obj in deactivators)
                   {
                     obj . SetActive (false);
                   }
                }
              


            }
          
        
       

        
            //find gameobject.tag, then convert it to a string and save it in a variable ex: string classTag = gameObject.tag
            //HandleClassTags(classTag)

        

    }
   
    
    void Start()
    {
        if ( tutorialObj != null && GameManager . currentLevel <= 1 )
        {
            tutorialObj . SetActive (true);
        }
        else
        {
            tutorialObj . SetActive (false);
        }
    }


    public void HandleClassTags(string tag)
    {
        switch (tag)
        {
            case "Dummy":
                Instantiate (Dummy , Spawn1 . transform . position , Quaternion . identity);

                break;
            case "Ranger":
                Instantiate(Ranger, Spawn1.transform.position, Quaternion.identity);
             
                break;
            case "Knight":
                Instantiate(Knight, Spawn1.transform.position, Quaternion.identity);
             
                break;
            case  "Cleric":
                Instantiate(Cleric, Spawn1.transform.position, Quaternion.identity);
     
                break;
            case "Wizard":
                Instantiate(Wizard, Spawn1.transform.position, Quaternion.identity);
           
                break;
            case  "Monk":
                Instantiate(Monk, Spawn1.transform.position, Quaternion.identity);
             
                break;
            case  "Druid":
                Instantiate(Druid, Spawn1.transform.position, Quaternion.identity);
       
                break;
            case  "Alchemist":
                Instantiate(Alchemist, Spawn1.transform.position, Quaternion.identity);
            
                break;
            case "Rogue":
                Instantiate(Rogue, Spawn1.transform.position, Quaternion.identity);
               
                break;
            case  "Paladin":
                Instantiate(Paladin, Spawn1.transform.position, Quaternion.identity);
           
                break;
            case "Necromancer":
                Instantiate(Necromancer, Spawn1.transform.position, Quaternion.identity);
            
                break;

            case "PlagueDoctor":
                Instantiate (Plague , Spawn1 . transform . position , Quaternion . identity);

                break;
            case "SpiritMaster":
                Instantiate (Master , Spawn1 . transform . position , Quaternion . identity);

                break;
            case "Merchant":
                Instantiate(Merchant, Spawn1.transform.position, Quaternion.identity);

                break;
            case "Candle":
                Instantiate (Candle , Spawn1 . transform . position , Quaternion . identity);

                break;
            case "Bard":
                Instantiate (Bard , Spawn1 . transform . position , Quaternion . identity);

                break;
            case "Puppeteer":
                Instantiate (Puppeteer , Spawn1 . transform . position , Quaternion . identity);

                break;
            case "FortNight":
                Instantiate (Fortnight, Spawn1 . transform . position , Quaternion . identity);

                break;
            default:
                Debug.Log("Didn't Contain tag");
                break;
        }
    }
}
