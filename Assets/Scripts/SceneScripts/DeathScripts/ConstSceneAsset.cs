using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;
using UnityEngine . SceneManagement;

public class ConstSceneAsset : MonoBehaviour
{
    // Start is called before the first frame update

   
    void Start()
    {
        GameObject . DontDestroyOnLoad (this . gameObject);
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if(sceneName != "MapMenu")
        {
            if ( sceneName != "Select" )
            {
                Destroy (gameObject);
            }
           
        }
        
    }

}
