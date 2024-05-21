using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGplus : MonoBehaviour
{

    public int ngint;
    public AudioClip sfx;

    public void Start ( )
    {


        if ( ngint > GameManager . maxNG )
        {
            gameObject . SetActive (false);
        }
    
    }

    public void ClickNG()
    {
        SoundManager . Instance . PlaySound (sfx);

        GameManager . currentNG = ngint;
        GameManager . currentLevel = 1;
        GameManager . regionSel = 1;


        if(ngint == GameManager.maxNG)
        {
            GameManager . maxNG += 1;
        }

        Debug . Log ("Max NG+" + GameManager . maxNG);
        Debug . Log ("Current NG+" + GameManager . currentNG);
    }
}
