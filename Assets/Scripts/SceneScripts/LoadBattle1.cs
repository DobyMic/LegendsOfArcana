using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . SceneManagement;
using UnityEngine . UI;

public class LoadBattle : MonoBehaviour
{

    public string levelName;
    public void Click()
    {

        


        Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;
     





            if ( sceneName == "MapMenu" )
            {
              SceneManager . LoadScene ("Select");
              GameObject.DontDestroyOnLoad(this.gameObject);

            }

            if ( sceneName == "Select" )
            {
                SceneManager . LoadScene (levelName);
                Destroy (gameObject);
            }
        
       


    }
 


  
}
