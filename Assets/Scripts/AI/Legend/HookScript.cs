using System . Collections . Generic;
using UnityEngine;
using System . Collections;
public class HookScript : MonoBehaviour
{
    public float attackInterval = 2.0f; // time between attacks
    public float attackRange = 1.0f; // range of attack
    public float attackDamage = 10.0f; // amount of damage dealt by attack


    public float critChance = 10;
    public float critDamage;


    public GameObject summon;
    public GameObject spawnPoint;
    private float lastAttackTime; // time of last attack

  
    public bool isCrit = false;

    public Animator animator;
    private void OnDrawGizmosSelected ( )
    {
        Gizmos . color = Color . red;
        Gizmos . DrawWireSphere (transform . position , attackRange);
       
    }


    private void Start ( )
    {

        attackDamage += GameManager . cosmo1;
        attackDamage = attackDamage * GameManager.unique1;
   


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

    public void Attack ( GameObject enemy )
    {

     

        // check if enough time has passed to attack again
        if ( Time . time - lastAttackTime >= attackInterval )
        {
            animator . SetTrigger ("Hook");
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
        yield return new WaitForSeconds (0.4f);

        var enemyHealth = enemy.GetComponent<Health>();
        if ( enemyHealth != null )
        {
            Instantiate (summon , spawnPoint . transform . position , Quaternion . identity);
            enemy . transform . position = spawnPoint . transform . position * Time . deltaTime;
            enemyHealth . TakeDamage (attackDamage);
           

        }
    }

}