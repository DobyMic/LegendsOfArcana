using System . Collections . Generic;
using UnityEngine;
using System . Collections;

public class Enemy : MonoBehaviour
{
    public float attackInterval = 2.0f; // time between attacks
    public float attackRange = 1.0f; // range of attack
    public float attackDamage = 10.0f; // amount of damage dealt by attack
    public float critChance = 10;
    public float critDamage;

    public bool isCrit = false;


    private float lastAttackTime; // time of last attack

    public Animator animator;

    public bool poison;

    public bool freezing;

    public bool scary;

    public bool summoner;

    public bool LifeSteal;

    public GameObject summon;


    private void OnDrawGizmosSelected ( )
    {
        Gizmos . color = Color . red;
        Gizmos . DrawWireSphere (transform . position , attackRange);
    }

    private void Start ( )
    {

        if(attackDamage != 0)
        {
            int scaleAMT = 0;
            if ( GameManager . currentNG != 0 )
            {
                scaleAMT = GameManager . currentNG * GameManager . currentNG * 50 + GameManager . cosmo1; ;
            }
            attackDamage += scaleAMT;
        
        }
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

    void Crit()
    {
        float critNumber = Random.Range(1,100);
    

        if ( critNumber <= critChance )
        {
            critDamage = (int)attackDamage / 2;
            isCrit = true;
        }
        else
        {
            isCrit = false;
            critDamage = 0;
        }
    }

    private void Update ( )
    {
        // find the nearest enemy with the tag "Enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Player");
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
            if ( isCrit == true )
            {
                enemyHealth . CritHit (damage . ToString ());
                isCrit = false;
            }
           

            if(poison == true)
            {
                enemyHealth.StartCoroutine(enemyHealth.poison());
            }

            if ( freezing == true )
            {
                enemyHealth . StartCoroutine (enemyHealth . freeze ());
            }
            if(scary == true)
            {
                enemyHealth . StartCoroutine (enemyHealth . feared ());
            }
            if(summoner == true)
            {
                Instantiate (summon , gameObject . transform . position , Quaternion . identity);
            }
            if(LifeSteal == true)
            {
                var life = gameObject . GetComponent<Health> ();
                life . Heal (damage);
            }

            enemyHealth . TakeDamage (damage);
        }
    }
}