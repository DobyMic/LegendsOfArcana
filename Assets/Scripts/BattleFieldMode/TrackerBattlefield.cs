using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;
using UnityEngine . SceneManagement;

public class TrackerBattlefield : MonoBehaviour
{

    public Text tracker1;
    public Text tracker2;
    public GameObject betWhisps;
    public GameObject betLava;
    public int resourceType1;

    public GameObject moneyTypeePanel;
    public GameObject sidePanel;


 
    public GameObject btnProceed;


    public AudioClip btnBet;
    public AudioClip btnType;
  


    public bool notBtn;
    private void Start ( )
    { 
        GameManager . whispsDead = 0;
        GameManager . ballsDead = 0;
        GameManager . teamLava = false;
        GameManager . teamWhisp = false;
        if (notBtn == true)
        {
            DontDestroyOnLoad (this . gameObject);
        }
 
        
    }


    public void BtnChooseLavaSide()
    {

        SoundManager . Instance . PlaySound (btnBet);
    
        GameManager . revealProceed += 1;
     
        GameManager . teamLava = true;
        sidePanel . SetActive(false);
        if ( GameManager . revealProceed >= 2 )
        {
            btnProceed . SetActive (true);

        }
    }

    public void BtnChooseWisp()
    {
       
        SoundManager . Instance . PlaySound (btnBet);
        GameManager . revealProceed += 1;
        betWhisps . SetActive (true);
        GameManager . teamWhisp = true;
   
        sidePanel . SetActive (false);
        if ( GameManager . revealProceed >= 2 )
        {
            btnProceed . SetActive (true);

        }
    }


    public void BtnSelectType()
    {
        SoundManager . Instance . PlaySound (btnType);
        GameManager .revealProceed += 1;
        GameManager . resourceType = resourceType1;
    
        moneyTypeePanel . SetActive (false);
        if ( GameManager . revealProceed >= 2 )
        {
            btnProceed . SetActive (true);

        }

    }



    // Update is called once per frame
    void Update()
    {
        
        if(GameManager.teamWhisp == true)
        {
            betWhisps . SetActive (true);

        }
        if ( GameManager . teamLava == true )
        {
            betLava . SetActive (true);

        }
        tracker1 . text = GameManager . whispsDead + "/50";
        tracker2 . text = GameManager . ballsDead + "/50";

      



      

        if ( GameManager . whispsDead >= 50 )
        {

            if ( GameManager . teamLava == true )
            {
                CollectBet ();
              
                SceneManager . LoadScene ("VIctory");
            }
            if ( GameManager . teamWhisp == true )
            {
                CollectLoss ();
            
                SceneManager . LoadScene ("Defeat");
            }

            Destroy (gameObject);
        }
        if(GameManager.ballsDead >= 50)
        {
            if ( GameManager . teamLava == true )
            {
                CollectLoss ();
    
                SceneManager . LoadScene ("Defeat");
            }
            if ( GameManager . teamWhisp == true )
            {
                CollectBet ();
   
                SceneManager . LoadScene ("VIctory");
            }
            Destroy (gameObject);
        }
    }




    void CollectBet()
    {
        switch ( GameManager . resourceType )
        {
            case 1:
                GameManager . essence += ( int ) GameManager . essence / 4;

                break;

            case 2:
                GameManager.reputation += ( int ) GameManager . reputation /4;
                break;


            case 3:
                GameManager . coins += ( int ) GameManager . coins/4;
                break;
           
        }


    
    }


    void CollectLoss ( )
    {
        switch ( GameManager . resourceType )
        {
            case 1:
                GameManager . essence -= ( int ) GameManager . essence / 4;

                break;

            case 2:
                GameManager . reputation -= ( int ) GameManager . reputation / 4;
                break;


            case 3:
                GameManager . coins -= ( int ) GameManager . coins / 4;
                break;

        }

    }
}
