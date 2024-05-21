using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . SceneManagement;

public class ChestOnDeath : MonoBehaviour
{
    public GameObject panel;

    private void OnDestroy ( )
    {

        StartCoroutine (scene ());
    }

    IEnumerator scene()
    {

        GameManager . LegendChest += 1;
        panel . SetActive (true);
        yield return new WaitForSeconds (3f);
        panel . SetActive (false);
        SceneManager . LoadScene ("VIctory");
    }
}
