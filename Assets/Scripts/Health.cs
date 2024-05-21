using UnityEngine;
//using System;
using UnityEngine.SceneManagement;
using UnityEngine . UI;
using System . Collections;
public class Health : MonoBehaviour
{

   
    public float maxHealth = 100.0f; // maximum health of enemy
    public float currentHealth; // current health of enemy


  

    [SerializeField] private GameObject floatingText;
    [SerializeField] private GameObject critText;
    public Text hpText;
    public bool fullHP;

    private bool critBool = false;


    public int beanLvl = 0;

    private bool isPoisoning = false;
    private bool isfreezing = false;
    
    private bool isfeared = false;

    private Vector3 freezePos;



    public int min;
    public int max;

    [HideInInspector]public float damageENUM;


  
    public bool HealthScaling;



    public GameObject poisonObj;
    public GameObject iceObj;
    public GameObject fearObj;
    public GameObject sunObj;

    public AudioClip takeDmgSfx;
    public AudioClip deathSfx;
    public AudioClip healSfx;
    
    

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if(sceneName == "VIctory")
        {
            Destroy (gameObject);
        }
        if ( sceneName == "Defeat" )
        {
            Destroy (gameObject);
        }
        if ( sceneName == "MapMenu" )
        {
            Destroy (gameObject);
        }

        if(currentHealth >= maxHealth)
        {
            fullHP = true;
            currentHealth = maxHealth;
        }
        else if(currentHealth <= maxHealth)
        {
            fullHP = false;
        }
        if ( gameObject . layer == 11 )
        {
            fullHP = true;
        }


        if(isfreezing == true)
        {
            gameObject . transform . position = freezePos;
        }


        int maxHpDis;

        if(currentHealth >= 100000 && currentHealth <= 1000000)
        {
            maxHpDis = ( int ) currentHealth / 1000;
            hpText . text = maxHpDis . ToString () + "K";
        }
        else if( currentHealth >= 1000000 && currentHealth <= 1000000000 )
        {
            maxHpDis = ( int ) currentHealth / 1000000;
            hpText . text = maxHpDis . ToString () + "M";
        }
        else if ( currentHealth >= 1000000000)
        {
            maxHpDis = ( int ) currentHealth / 1000000;
            hpText . text = maxHpDis . ToString () + "B";
        }
        else
        {
            maxHpDis = ( int ) currentHealth;
            hpText . text = maxHpDis . ToString ();
        }

        if(isPoisoning == true)
        {
            poisonTime += Time . deltaTime;

            if ( poisonTime >= 1f)
            {
                poisonTime = 0;
                TakeDamage (1 + (int)maxHealth/26);
                tickAmt += 1;

            }


            if( tickAmt >= 4f)
            {
                isPoisoning = false;
            }

        }

       

    }

    float poisonTime = 1f;
    int tickAmt = 0;
    
    void Awake()
    {

      
       
        if(gameObject.tag == "Enemy")
        {
            EnemyStats ();
           
        }
        else
        {
            SetStats ();
        }


    }
    
    void EnemyStats()
    {
        int scaleAMT = 1;
        if (GameManager.currentNG != 0)
        {
            scaleAMT = GameManager.currentNG *  GameManager .currentNG * 1000 + GameManager . cosmo1 ;
        }
     


        maxHealth = ( int ) scaleAMT * maxHealth;

             
            
             Mathf . Ceil (maxHealth);
            currentHealth = maxHealth;
            hpText . text = currentHealth . ToString ();
        
    }

   void SetStats()
    {
        maxHealth += GameManager . cosmo1;
        if ( HealthScaling == true )
        {
            maxHealth = GameManager.Armor1 * maxHealth ;
        }



        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;

        currentHealth = maxHealth;
        hpText . text = currentHealth . ToString ();
        if ( gameObject . tag == "Player" )
        {

            currentHealth = maxHealth;
            hpText . text = currentHealth . ToString ();

            if ( sceneName == "Select" )
            {
                GameObject . DontDestroyOnLoad (this . gameObject);
            }


            //VictoryManager.instance.AddLegend();
        }
    

      
    }


    public void Heal(float damage)
    {
        ShowDamage (damage . ToString ());
        currentHealth += damage;

        SoundManager . Instance . PlaySound (healSfx);

    }


    public void TakeDamage ( float damage )
    {
       
     
        
        // reduce current health by the amount of damage dealt
        currentHealth -= damage;
        damageENUM = damage;
        StartCoroutine (hitColour ());
        SoundManager . Instance . PlaySound (takeDmgSfx);

        // check if enemy is dead
        if ( currentHealth <= 0 )
        {
            Die ();
            return;
        }

        critBool = false;
        return;
    }

    public void Die()
    {
        SoundManager . Instance . PlaySound (deathSfx);
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
      

        if (gameObject.tag == "Enemy")
        {
            int killamt = Random.Range(min, max);
      
            if (sceneName == "Adventure")
            {
                killamt += killamt * 2;

            }

            if(sceneName == "AllForOne")
            {
                int repAMT = Random.Range(1,4*GameManager.currentNG );
                GameManager . soulFire += repAMT;
            }
            
          
            if(sceneName == "Waves")
            {
                killamt += killamt * 4;
            }

          
            GameManager . essence += killamt;
         

            if ( gameObject . layer == 11 )
            {

                
   


             
                SceneManager . LoadScene ("VIctory");
                SoundManager . Instance . PlayVictory ();
                if (GameManager.currentLevel <= beanLvl)
                {
                    GameManager . currentLevel = beanLvl + 1;
                }
           
                int amount = Random.Range(min, max);
        

                GameManager . reputation += amount + GameManager.currentNG;
                Destroy (gameObject);
                return;

            }
            Destroy (gameObject);
         
        }

        if(gameObject.tag == "Player")
        {

         
            if (gameObject.layer == 11)
            {
               
              
     
                SceneManager . LoadScene ("Defeat");
                SoundManager . Instance .PlayDefeat();
                int amount = Random.Range(-1, -50);

                GameManager . essence += amount;
                
            }




            Destroy (gameObject);
           
        }
        if (gameObject.tag == "Cleric")
        {

           
  
            Destroy(gameObject);

        }


        // destroy health bar and enemy game object




    }

    void ShowDamage(string text)
    {
        
        
            GameObject prefab = Instantiate(floatingText,transform.position,Quaternion.identity);
            prefab . transform . position = new Vector3 (prefab . transform . position . x + Random . Range (-1f , 1f) , prefab . transform . position . y + Random.Range(0.5f, 1f),-4);
            prefab . GetComponent<TextMesh> () . text = text;
            return;
   
     
    }

    public void CritHit(string text)
    {
        if(gameObject.tag != "Player")
        {
            critBool = true;
            GameObject crit = Instantiate(critText,transform.position,Quaternion.identity);
            crit . transform . position = new Vector3 (crit . transform . position . x + Random . Range (-1f , 1f) , crit . transform . position . y + Random . Range (0.5f , 1f) , -4);
            crit . GetComponent<TextMesh> () . text = "*" + text;
            return;
        }
      
    }





    private IEnumerator hitColour ( )
    {
        var colourHit = gameObject.GetComponent<SpriteRenderer>();

        if ( isPoisoning != true && isfeared != true && isfreezing != true)
        {
            colourHit . color = Color . red;
        }






        if ( critBool == false && gameObject . tag != "Player" )
        {

            if(damageENUM >= 1000000f && damageENUM !> 1000000000)
            {
                ShowDamage (damageENUM / 1000000f + "M");
                
            }
            if ( damageENUM >= 1000000000 )
            {
                ShowDamage (damageENUM / 1000000000f + "B");
            }
            else
            {
                ShowDamage (damageENUM.ToString());
            }


          


        }

        yield return new WaitForSeconds (0.3f);
        if ( isPoisoning != true && isfreezing != true && isfeared != true)
        {
            colourHit . color = Color . white;
        }
    }
 

    public IEnumerator freeze()
    {
   
        isfreezing = true;
        var colourHit = gameObject.GetComponent<SpriteRenderer>();
        colourHit . color = Color.blue;
        Instantiate (iceObj , gameObject . transform . position , Quaternion . identity);
        Vector3 currentPos = gameObject.transform.localPosition;
        freezePos = currentPos;
        yield return new WaitForSeconds (1.5f);
        isfreezing = false;
    
        colourHit . color = Color . white;
    }

   

    public IEnumerator poison()
    {

        var colourHit = gameObject.GetComponent<SpriteRenderer>();
        isPoisoning = true;
        var spawn = Instantiate(poisonObj, gameObject.transform.position, Quaternion.identity);
        spawn . transform . parent = gameObject . transform;

        colourHit . color = Color . green;


        yield return new WaitForSeconds (1f);

    }


    public IEnumerator smile(int damage)
    {
        var spawn = Instantiate(sunObj, gameObject.transform.position, Quaternion.identity);
        spawn . transform . parent = gameObject . transform;
        yield return new WaitForSeconds (0.75f);
        TakeDamage ((int)damage / 2);
    }

    public IEnumerator feared()
    {


        if (isfeared != true)
        {
            isfeared = true;
            var colourHit = gameObject.GetComponent<SpriteRenderer>();
            colourHit . color = Color . black;
            var spawn = Instantiate(fearObj, gameObject.transform.position, Quaternion.identity);
            spawn . transform . parent = gameObject . transform;


            if ( gameObject . tag == "Enemy" )
            {
                var mov = gameObject . GetComponent<EnemyMove> ();
                if(mov != null)
                {
                    mov . running = true;
                }

              
            }
            if ( gameObject . tag == "Player" )
            {
                var mov1 = gameObject . GetComponent<LegendMove> ();
                if ( mov1 != null )
                {
                    mov1.running = true;
                }
                   
          
            }

            yield return new WaitForSeconds (1f);

            if ( gameObject . tag == "Enemy" )
            {
                var mov = gameObject . GetComponent<EnemyMove> ();
                if ( mov != null )
                {
                    mov . running = false;
                }

       
            }
            if ( gameObject . tag == "Player" )
            {
                var mov1 = gameObject . GetComponent<LegendMove> ();
                if ( mov1 != null )
                {
                   
                        mov1 . running = true;
                    
                }
              
            }
         

            isfeared = false;
            colourHit . color = Color . white;
        }
     
    }


}