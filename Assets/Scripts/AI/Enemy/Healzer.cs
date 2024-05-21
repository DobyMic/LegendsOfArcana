using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healzer : MonoBehaviour
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



    private void OnDrawGizmosSelected ( )
    {
        Gizmos . color = Color . red;
        Gizmos . DrawWireSphere (transform . position , attackRange);
    }

    private void Start ( )
    {

        int scaleAMT = 0;
        if ( GameManager . currentNG != 0 )
        {
            scaleAMT = GameManager . currentNG * GameManager . currentNG * 50 + GameManager.cosmo1;
        }
        attackDamage += scaleAMT;
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

    void Crit ( )
    {
        float critNumber = Random.Range(1,100);


        if ( critNumber <= critChance )
        {
            critDamage = ( int ) attackDamage / 2;
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
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        GameObject nearestEnemy = null;
        float nearestDistance = Mathf.Infinity;

        foreach ( GameObject enemy in enemies )
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            var enemyHealth = enemy.GetComponent<Health>();

            // Check if the enemy has missing health and is within the attack range
            if ( distance <= attackRange && distance < nearestDistance && !enemyHealth . fullHP )
            {
                nearestEnemy = enemy;
                nearestDistance = distance;
            }
        }

        // Heal the nearest enemy with missing health
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
            enemyHealth . Heal (damage);

        


        }
    }
}
