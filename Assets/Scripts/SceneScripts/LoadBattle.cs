using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . SceneManagement;
using UnityEngine . UI;

public class LoadBattle1 : MonoBehaviour
{

    public string levelName;

    public GameObject battleButton;
    public GameObject mapButton;
    public int thisLevel;
    public bool allFor1;
    public bool ngUnlocked;
    private bool unlockOnNg;

    public AudioClip mapSfx;
    public AudioClip battleSfx;
    public AudioClip select;
    public AudioClip musicSwap;

    public void Click()
    {

        GameObject . DontDestroyOnLoad (this . gameObject);


        Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;
     





            if ( sceneName == "MapMenu" )
            {

              SoundManager . Instance . PlaySound (mapSfx);
              SceneManager.LoadScene("Select");

            



              Destroy (mapButton);
               if(allFor1 == true)
               {
                   GameManager . allForOne = true;
               }
              if ( musicSwap == null )
              {
                return;
              }
              else
              {
                SoundManager . Instance . ChangeMusic (select);
              }

            }

            if ( sceneName == "Select" )
            {
               SoundManager . Instance . PlaySound (battleSfx);
               SceneManager . LoadScene (levelName);



           
               if (GameManager.allForOne == true)
               {
                   GameManager . allForOne = false;
               }
                Destroy (gameObject);

              if ( musicSwap == null )
              {
                return;
              }
              else
              {
                SoundManager . Instance . ChangeMusic (musicSwap);
              }
            }
        
       


    }

    void Update()
    {

        if(GameManager.maxNG >= 1 && ngUnlocked == true)
        {
            ngUnlocked = true;
        }
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if ( sceneName == "Select" )
        {

            battleButton . SetActive (true);
        }
        if (GameManager.currentLevel >= thisLevel || ngUnlocked == true)
        {
            mapButton . SetActive (true);

            
        }
        else
        {
            mapButton . SetActive (false);

        }

       

    
    }
 
  


  
}
