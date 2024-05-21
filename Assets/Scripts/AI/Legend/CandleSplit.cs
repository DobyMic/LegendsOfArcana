using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleSplit : MonoBehaviour
{
    public float attackInterval = 2.0f; // time between attacks
    public float attackRange = 1.0f; // range of attack
    public float attackDamage = 10.0f; // amount of damage dealt by attack

    public Animator animator;

    public GameObject mini;


    public GameObject spawnPoint;
    public GameObject spawnPoint2;



    private float lastAttackTime; // time of last attack


    private void Start()
    {
      
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
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


    private void Update()
    {
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
        Instantiate (mini , spawnPoint . transform . position , Quaternion . identity);
        yield return new WaitForSeconds (0.3f);
        var enemyHealth = gameObject.GetComponent<Health>();
        if ( enemyHealth != null )
        {

            enemyHealth . TakeDamage (attackDamage);
       


            
        }
    }



}




