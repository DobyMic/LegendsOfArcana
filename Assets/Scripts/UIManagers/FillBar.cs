using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine . SceneManagement;

public class FillBar : MonoBehaviour
{

    public Health Health;
    public Image fillImage;
    private Slider slider;

    public GameObject UI1;
    public GameObject UI2;
    public GameObject UI3;
    public GameObject UI4;

    private GameObject filler;

    void FixedUpdate ( )
    {

        float fillValue = Health.currentHealth;
        slider . value = fillValue;

        if ( slider . value <= slider . minValue )
        {
            fillImage . enabled = false;
            //Destroy (gameObject);
        }

        if ( slider . value > slider . minValue && !fillImage . enabled )
        {

            fillImage . enabled = true;
        }


    }
    public void Start ( )
    {


        slider = GetComponent<Slider> ();
        slider . maxValue = Health . maxHealth;

        UI1 = GameObject . Find ("Slot1");
        UI2 = GameObject . Find ("Slot2");
        UI3 = GameObject . Find ("Slot3");
        UI4 = GameObject . Find ("Slot4");

        filler = new GameObject ();




        if ( UI1 . transform . childCount <= 0 )
        {
            filler . transform . parent = UI1 . transform;
            gameObject . transform . position = UI1 . transform . position;


            return;
        }

        if ( UI2 . transform . childCount <= 0 )
        {
            filler . transform . parent = UI2 . transform;
            gameObject . transform . position = UI2 . transform . position;


            return;

        }
        if ( UI3 . transform . childCount <= 0 )
        {
            filler . transform . parent = UI3 . transform;
            gameObject . transform . position = UI3 . transform . position;


            return;

        }
        if ( UI4 . transform . childCount <= 0 )
        {
            filler . transform . parent = UI4 . transform;
            gameObject . transform . position = UI4 . transform . position;


            return;

        }


    }
    // Start is called before the first frame update

 


}
