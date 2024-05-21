using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeathScript : MonoBehaviour
{

    public GameObject spawner;
    void OnDestroy()
    {
        Instantiate (spawner);
    }
}
