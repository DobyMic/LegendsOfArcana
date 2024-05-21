using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockOnLevel : MonoBehaviour
{
    public int unlockLevel;

    // Update is called once per frame
    void Update()
    {
        if(GameManager.currentLevel < unlockLevel)
        {
            gameObject . SetActive (false);
        }
        else
        {
            gameObject . SetActive (true);
        }
    }
}
