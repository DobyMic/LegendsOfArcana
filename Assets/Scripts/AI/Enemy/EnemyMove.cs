using System . Collections . Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
   
    public float moveSpeed = 5.0f; // speed of movement
    public float detectionRange = 10.0f; // range for detecting enemies
    public float minDistanceToEnemy = 2.0f; // minimum distance to enemy before attacking

    public float startspeed;
    private Vector2 moveDirection;

    public bool running;


    private void OnDrawGizmosSelected ( )
    {
        Gizmos . color = Color . blue;
        Gizmos . DrawWireSphere (transform . position , detectionRange);
    }

    private void Start ( )
    {
        moveDirection = Vector2 . right; // start moving to the right
    }

    private void Update ( )
    {
        moveSpeed = startspeed;
        // find the nearest enemy with the tag "Enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Player");
        GameObject nearestEnemy = null;
        float nearestDistance = Mathf.Infinity;
        foreach ( GameObject enemy in enemies )
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            if ( distance <= detectionRange && distance < nearestDistance )
            {
                nearestEnemy = enemy;
                nearestDistance = distance;
            }
        }

        if ( nearestEnemy != null )
        {
            if ( running == true )
            {
                nearestEnemy = null;
            }
            // move towards nearest enemy if not in attack range
            float distanceToEnemy = Vector2.Distance(transform.position, nearestEnemy.transform.position);
            if ( distanceToEnemy > minDistanceToEnemy )
            {
                moveDirection = ( nearestEnemy . transform . position - transform . position ) . normalized;
            }
            else
            {
                // attack if in attack range
                var legendAI = GetComponent<Enemy>();
                if ( legendAI != null )
                {
                    moveSpeed = 0f;
                    legendAI . Attack (nearestEnemy);

                }
            }
        }
        else
        {
            // patrol randomly if no enemies detected
            moveDirection = Vector2 . zero;
        }
    }

    private void FixedUpdate ( )
    {
        // move in current direction
        if(running == true)
        {
            transform . Translate (moveDirection * -moveSpeed * Time . deltaTime);
        }
        else
        {
            transform . Translate (moveDirection * moveSpeed * Time . deltaTime);
        }
     

    }
}