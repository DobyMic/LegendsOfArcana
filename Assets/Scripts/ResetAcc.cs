using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAcc : MonoBehaviour
{
 

    public void resetFunction()
    {
        GameManager . Instance . resetAcc ();
    }

    public void Quit123 ( )
    {
        Application . Quit ();
    }
}
