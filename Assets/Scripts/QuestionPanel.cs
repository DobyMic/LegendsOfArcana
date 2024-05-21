using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionPanel : MonoBehaviour
{

    public AudioClip btnAudio;
    public GameObject panel;


    public void panelStatus()
    {
        SoundManager . Instance . PlaySound (btnAudio);
        panel . SetActive (!panel.activeInHierarchy);  
    }

}
