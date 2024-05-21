using System . Collections . Generic;
using UnityEngine;
using System . Collections;
public class LegendAI : MonoBehaviour
{
    public float attackInterval = 2.0f; // time between attacks
    public float attackRange = 1.0f; // range of attack
    public float attackDamage = 10.0f; // amount of damage dealt by attack

    public Animator animator;
  
    private float lastAttackTime; // time of last attack

    public bool isCrit = false;

    public bool magical;
    public bool physical;
    public bool minion;
    public bool criticalScale;
    public bool doublePower;

    public float critChance = 5;
    public float critDamage;

    public bool poison;

    public bool freezing;

    public bool scary;

    public bool summoner;

    public bool bargain;

    public bool thrower;

    public bool puppeteer;

    public GameObject summon;



    private bool puppetFEARED;
    private void Start ( )
    {

        if(attackDamage != 0)
        {
            attackDamage += GameManager . cosmo1;
        }

        if(magical == true)
        {
           
            if ( doublePower == true )
            {
                attackDamage = GameManager . magic1 * attackDamage + GameManager . magic1;
            }
            else
            {
                attackDamage = GameManager . magic1 * attackDamage;
            }
        }
        if(physical == true)
        {
          
            if ( doublePower == true )
            {
                attackDamage = GameManager . physical1 * attackDamage + GameManager . physical1;
            }
            else
            {
                attackDamage = GameManager . physical1 * attackDamage;
            }
        }
        if(minion == true)
        {
            if ( doublePower == true )
            {
                attackDamage = GameManager . summonPower1 * attackDamage + GameManager . summonPower1;
            }
            else
            {
                attackDamage = GameManager . summonPower1 * attackDamage;
            }
        }
        if ( criticalScale == true )
        {
            critChance = GameManager . critChance1 + critChance;
         
            
        }
        if(bargain == true)
        {
            attackDamage = GameManager . unique1 * attackDamage;
        }
       

        
      
    }

    void Crit ( )
    {
        float critNumber = Random.Range(1,100);


        if ( critNumber <= critChance )
        {
          
            critDamage = ( int ) attackDamage / 2;
            isCrit = true;
            if ( criticalScale == true )
            {
                critDamage += (int)GameManager . critChance1 /2;
             
            }
        }
        else
        {
            critDamage = 0;
            isCrit = false;
        }
    }
    private void OnDrawGizmosSelected ( )
    {
        Gizmos . color = Color . red;
        Gizmos . DrawWireSphere (transform . position , attackRange);
    }


    public void Attack ( GameObject enemy )
    {
  
        // check if enough time has passed to attack again
        if ( Time . time - lastAttackTime >= attackInterval )
        {
            animator . SetTrigger ("Attack");
            // check if enemy is in attack range
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            if ( distance <= attackRange )
            {

                StartCoroutine (Hit (enemy));

      

                // update last attack time
                lastAttackTime = Time . time;
            }
        }
    }

    private void Update ( )
    {
        // find the nearest enemy with the tag "Enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject nearestEnemy = null;
        float nearestDistance = Mathf.Infinity;
        foreach ( GameObject enemy in enemies )
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            if ( distance <= attackRange && distance < nearestDistance )
            {
                nearestEnemy = enemy;
                nearestDistance = distance;
            }
        }

        // attack nearest enemy
        if ( nearestEnemy != null )
        {
           
            Attack (nearestEnemy);

            
        }
    }

    public IEnumerator Hit ( GameObject enemy )
    {
        yield return new WaitForSeconds (0.3f);
        var enemyHealth = enemy.GetComponent<Health>();
        if ( enemyHealth != null )
        {

            Crit ();
            float damage = attackDamage + critDamage;
            // animator.SetTrigger("Attack");
            if ( isCrit == true )
            {
                enemyHealth . CritHit (damage . ToString ());
                isCrit = false;
            }
        

            if ( poison == true )
            {
                enemyHealth . StartCoroutine (enemyHealth . poison ());
            }

            if ( freezing == true )
            {
                enemyHealth . StartCoroutine (enemyHealth . freeze ());
            }
            if ( scary == true )
            {
                enemyHealth . StartCoroutine (enemyHealth . feared ());
            }
            if(summoner == true)
            {
                Instantiate (summon , gameObject . transform . position , Quaternion . identity);
            }
            if(bargain == true)
            {
                GameManager . coins += ( int ) damage * Random . Range (1 , 10);
            }
            if(thrower == true)
            {
                Instantiate (summon , enemy.transform.position , Quaternion . identity);
            }
            if(puppeteer == true)
            {
                enemyHealth . StartCoroutine (enemyHealth . smile ((int)damage));
          

            }

            enemyHealth . TakeDamage (damage);
        }
    }


}