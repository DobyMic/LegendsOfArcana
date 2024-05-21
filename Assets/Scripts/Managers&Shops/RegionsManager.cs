using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionsManager : MonoBehaviour
{


    public GameObject[] Region1;
    public GameObject[] Region2;
    public GameObject[] Region3;
   
    public GameObject[] Town;

    public GameObject nextButton;
    public GameObject previousButton;


    public int activeRegion = 0;

    public AudioClip r1Music,r2Music,r3Music,r4Music;

    public GameObject tutorial1,tutorial2,tutorial3,tutorial4,tutorial5,tutorial6,tutorial7,tutorial13,tutorial19,finaltutorial;



    public AudioClip regionswapSfx;
    // Start is called before the first frame update


    public void LoadNextRegion()
    {
        GameManager.regionSel += 1;
        SoundManager . Instance . PlaySound (regionswapSfx);

        MusicConfig ();
        if (activeRegion >= 4)
        {
            activeRegion = 4;
        }
    }

    public void LoadPreviousRegion()
    {
        GameManager.regionSel -= 1;
        SoundManager . Instance . PlaySound (regionswapSfx);
        MusicConfig ();
        if ( activeRegion <= 1 )
        {
            activeRegion = 1;
        }
    }
    void Start()
    {
        activeRegion = 1;

      



        

        if ( r1Music == null )
        {
            return;
        }
        else
        {
            SoundManager . Instance . ChangeMusic (r1Music);
        }

        handleTutorial ();
    }


    void MusicConfig( )
    {
     
        switch ( GameManager.regionSel )
        {
            case 1:
                if ( r1Music == null )
                {
                    return;
                }
                else
                {
                    SoundManager . Instance . ChangeMusic (r1Music);
                }
                break;

            case 2:
                if ( r2Music == null )
                {
                    return;
                }
                else
                {
                    SoundManager . Instance . ChangeMusic (r2Music);
                }
                break;
            case 3:
                if ( r3Music == null )
                {
                    return;
                }
                else
                {
                    SoundManager . Instance . ChangeMusic (r3Music);
                }
                break;
            case 4:
                if ( r4Music == null )
                {
                    return;
                }
                else
                {
                    SoundManager . Instance . ChangeMusic (r4Music);
                }
                break;


        }

    }
    // Update is called once per frame
    void Update ( )
    {
        activeRegion = GameManager . regionSel;




        if ( activeRegion <= 1)
        {

          
            previousButton . SetActive (false);
            if(GameManager.currentLevel <= 6)
            {
                nextButton . SetActive (false);
            }
          
            foreach ( GameObject go in Region1 )
            {
                go . SetActive (true);
            }

        }
        else
        {

            previousButton . SetActive (true);
            foreach ( GameObject go in Region1 )
            {
                go . SetActive (false);
            }
        }
    

        if ( activeRegion == 2 )
        {
         
            foreach ( GameObject go in Region2 )
            {
                go . SetActive (true);
            }

        }
        else
        {
            foreach ( GameObject go in Region2 )
            {
                go . SetActive (false);
            }
        }

        if ( activeRegion == 3 )
        {
        
            foreach ( GameObject go in Region3 )
            {
                go . SetActive (true);
            }

        }
        else
        {
            foreach ( GameObject go in Region3 )
            {
                go . SetActive (false);
            }
        }

  

        if ( activeRegion >= 4  )
        {
            
            nextButton . SetActive (false);
            foreach ( GameObject go in Town )
            {
                go . SetActive (true);
            }

        }
        else
        {
            if(GameManager.currentLevel > 6)
            {
                nextButton . SetActive (true);
            }

            foreach ( GameObject go in Town )
            {
                go . SetActive (false);
            }
        }







    }



    public void handleTutorial( )
    {
        int tracker = GameManager.currentLevel;

        switch (tracker)
        {

            case 1 :
                if( GameManager . beginnerLvl == 0 )
                {
                    tutorial1 . SetActive (true);

                    GameManager . beginnerLvl += 1;
                }
          
                break;
            case 2:
                if ( GameManager . beginnerLvl == 1 )
                {
                    tutorial2 . SetActive (true);

                    GameManager . beginnerLvl += 1;
                }

                break;

            case 3:
                if ( GameManager . beginnerLvl == 2 )
                {
                    tutorial3 . SetActive (true);
                    GameManager . HireWizard += 60;
                    GameManager . soulFire += 10;
                    GameManager . beginnerLvl += 1;
                }
               
                break;
            case 4:

                if ( GameManager . beginnerLvl == 3 )
                {
                    tutorial4 . SetActive (true);
                    GameManager . essence += 6000;
                    GameManager . RUNEcosmo += 1;
                    GameManager . beginnerLvl += 1;
                }
                 
                break;

            case 5:
                if ( GameManager . beginnerLvl == 4 )
                {
                    tutorial5 . SetActive (true);
                    GameManager . essence += 20000;
                    GameManager . RUNEArmor += 1;
                    GameManager . beginnerLvl += 1;
                }
                  
                break;

            case 6:
                if ( GameManager . beginnerLvl == 5 )
                {
                    tutorial6 . SetActive (true);
                    GameManager . soulFire += 10;
                    GameManager . HireWizard += 60; 
                    GameManager . beginnerLvl += 1;
                }
                   
                break;

            case 7:
                if ( GameManager . beginnerLvl == 6 )
                {
                    tutorial7 . SetActive (true);
                    GameManager . beginnerLvl += 1;
                }
                break;


            case 13:
                if ( GameManager . beginnerLvl == 7 )
                {
                    tutorial13 . SetActive (true);

                    GameManager . beginnerLvl += 1;
                }
                break;

            case 19:
                if ( GameManager . beginnerLvl == 8 )
                {
                    tutorial19 . SetActive (true);

                    GameManager . beginnerLvl += 1;
                }
                break;
            case 23:
                if ( GameManager . beginnerLvl == 9 )
                {
                    finaltutorial . SetActive (true);

                    GameManager . beginnerLvl += 1;
                }
                break;










        }


    }
}
