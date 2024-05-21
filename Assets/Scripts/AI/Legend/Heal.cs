using System . Collections . Generic;
using UnityEngine;
using System . Collections;
public class Heal : MonoBehaviour
{
    public float attackInterval = 2.0f; // time between attacks
    public float attackRange = 1.0f; // range of attack
    public float attackDamage = 10.0f; // amount of damage dealt by attack

    public bool isCrit = false;

    public float critChance = 5;
    public float critDamage;

    public bool criticalScale;

    public bool HealingMEGA;



    private float lastAttackTime; // time of last attack
    public Animator animator;

    private void Start ( )
    {

        attackDamage += GameManager . cosmo1;

        if(HealingMEGA == true)
        {
            attackDamage = GameManager . healing1 * attackDamage + GameManager.healing1;
        }
        else
        {
            attackDamage = GameManager . healing1 * attackDamage;
        }

        if ( criticalScale == true )
        {
            critChance = GameManager . critChance1 + critChance;

        }



    }

    void Crit ( )
    {
        float critNumber = Random.Range(1,100);


        if ( critNumber <= critChance )
        {
            if ( criticalScale == true )
            {
                critDamage = (int)critDamage + GameManager . critChance1 / 2;

            }
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
        Gizmos . color = Color . green;
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
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Player");

        GameObject nearestEnemy = null;
        float nearestDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            var enemyHealth = enemy.GetComponent<Health>();

            // Check if the enemy has missing health and is within the attack range
            if (distance <= attackRange && distance < nearestDistance && !enemyHealth.fullHP)
            {
                nearestEnemy = enemy;
                nearestDistance = distance;
            }
        }

        // Heal the nearest enemy with missing health
        if (nearestEnemy != null)
        {
            Attack(nearestEnemy);
      
        }
    }
    public IEnumerator Hit ( GameObject enemy )
    {
        yield return new WaitForSeconds (0.4f);
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
            enemyHealth . Heal (damage);

        }
    }
}
