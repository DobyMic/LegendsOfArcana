using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : MonoBehaviour
{
    public float attackInterval = 2.0f; // time between attacks
    public float attackRange = 1.0f; // range of attack
    public float attackDamage = 10.0f; // amount of damage dealt by attack



    public bool isCrit = false;

    public float critChance = 10;
    public float critDamage;

    public GameObject affectPaladin;

    public Animator animator;

    private float lastAttackTime; // time of last attack




    private void Start ( )
    {
        attackDamage += GameManager . cosmo1;

        attackDamage = GameManager . healing1 + attackDamage * GameManager . unique1;


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
            critDamage = 0;
            isCrit = false;
        }
    }
    private void OnDrawGizmosSelected ( )
    {
        Gizmos . color = Color . red;
        Gizmos . DrawWireSphere (transform . position , attackRange);
    }


    public void Attack ( GameObject [ ] enemy )
    {

        // check if enough time has passed to attack again
        if ( Time . time - lastAttackTime >= attackInterval )
        {
            animator . SetTrigger ("Attack");
            // check if enemy is in attack range

            foreach ( GameObject enem in enemy )
            {
                float distance = Vector2.Distance(transform.position, enem.transform.position);
                if ( distance <= attackRange )
                {

                    StartCoroutine (Hit (enem));



                    // update last attack time
                    lastAttackTime = Time . time;
                }
            }

        }
    }

    private void Update ( )
    {
        // find the nearest enemy with the tag "Enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Player");

        float nearestDistance = Mathf.Infinity;
        foreach ( GameObject enemy in enemies )
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            if ( distance <= attackRange && distance < nearestDistance )
            {

                nearestDistance = distance;
            }
        }

        // attack nearest enemy
        if ( enemies != null )
        {

            Attack (enemies);


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

            enemyHealth . maxHealth += attackDamage;
            enemyHealth . Heal (damage);
        }
    }
}
