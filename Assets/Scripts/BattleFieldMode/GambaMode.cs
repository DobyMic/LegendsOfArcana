using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GambaMode : MonoBehaviour
{

    public GameObject lavaObj;
    public GameObject whispObj;
    private float timer1;
    private float timer2;
    private void Update ( )
    {


        timer1 -= Time . deltaTime;
        timer2 -= Time . deltaTime;

        if ( timer1 <= 0f )
        {
            Instantiate (lavaObj , new Vector2 (Random . Range (30 , 1) , Random . Range (13 , -13)) , Quaternion . identity);
           
            timer1 = Random.Range(0.1f,2f);
        }


        if ( timer2 <= 0f )
        {

            Instantiate (whispObj , new Vector2 (Random . Range (-30 , -1) , Random . Range (13 , -13)) , Quaternion . identity);

            timer2 = Random . Range (0.1f , 2f);
        }
    }
    
}
