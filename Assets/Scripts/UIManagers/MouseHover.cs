using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;

public class MouseHover : MonoBehaviour
{

    public GameObject hoverObj;


    public void  ActivateObj( )
    {
        StartCoroutine (showHover ());
        //hoverObj . SetActive (true);
    }

    public void DeactivateObj( )
    {
        StartCoroutine (hideHover ());
        // hoverObj . SetActive (false);
    }


    IEnumerator showHover ( )
    {
        yield return new WaitForSeconds (0.1f);
        hoverObj . SetActive (true);
    }

    IEnumerator hideHover ( )
    {
        yield return new WaitForSeconds (0.2f);
        hoverObj . SetActive (false);
    }
}
