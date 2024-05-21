using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string SceneName;
    public AudioClip btnClick;
    public AudioClip musicSwap;
   
    public void SceneLoad()
    {

        int loadNumb = Random.Range(1,5);

        switch(loadNumb)
        {
            case 1:
                Instantiate (GameManager.Instance.loading1 , transform . position , Quaternion . identity);
                break;

            case 2:
                Instantiate (GameManager . Instance . loading2 , transform . position , Quaternion . identity);
                break;

            case 3:
                Instantiate (GameManager . Instance . loading3 , transform . position , Quaternion . identity);
                break;

            case 4:
                Instantiate (GameManager . Instance . loading4 , transform . position , Quaternion . identity);
                break;

            case 5:
                Instantiate (GameManager . Instance . loading5 , transform . position , Quaternion . identity);
                break;


        }
        
        
        

        
        SceneManager . LoadScene (SceneName);
        SoundManager . Instance . PlaySound (btnClick);
      
        if(musicSwap == null)
        {
            return;
        }
        else
        {
            SoundManager . Instance . ChangeMusic (musicSwap);
        }
    }
}
