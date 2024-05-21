using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpenBtn : MonoBehaviour
{

    public GameObject panel;
    public GameObject otherPanels;
    public AudioClip btnAudio;


    private void Update ( )
    {
 
    }
    public void OpenPanel()
    {
        panel . SetActive (true);
        otherPanels . SetActive (false);
        SoundManager . Instance . PlaySound (btnAudio);
    }


    public void ClosePanel()
    {
        panel . SetActive (false);
        otherPanels . SetActive (true);
        SoundManager . Instance . PlaySound (btnAudio);
    }
}
