using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;
public class ToggleSfx : MonoBehaviour
{
    public AudioClip clickSfx;
    public bool sfx,music;
    public Image toggleImg;
      public void toggle()
      {
        if(sfx)
        {
            SoundManager . Instance . toggleSfx ();
            toggleImg . enabled = !toggleImg . enabled;
        }

        if(music)
        {
            SoundManager . Instance . toggleMusic ();
            toggleImg . enabled = !toggleImg . enabled;
        }

      }

}
