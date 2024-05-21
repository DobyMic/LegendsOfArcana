using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . SceneManagement;

public class ReturnMap : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string myName = currentScene.name;
        if ( myName != "Select" )
        {
            gameObject . SetActive (true);
        }
        if ( myName == "Select" )
        {
            gameObject . SetActive (false);
        }
     
    }
    public void SceneLoad ( )
    {
        SceneManager . LoadScene (SceneName);
    }
}
