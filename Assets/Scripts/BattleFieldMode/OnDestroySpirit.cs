using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroySpirit : MonoBehaviour
{

    public bool whisp;
    public bool flame;


    private void OnDestroy ( )
    {
        if(whisp == true)
        {
            GameManager . whispsDead += 1;
        }

        if(flame == true)
        {
            GameManager . ballsDead += 1;
        }
    }
}
