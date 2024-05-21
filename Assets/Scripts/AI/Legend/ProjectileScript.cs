using System . Collections;
using System . Collections . Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Transform[] playerTransforms;
    private int currentTargetIndex = 0;

    void Start ( )
    {
        // Find all player transforms in the scene and store them in an array
        GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");
        playerTransforms = new Transform [ playerObjects . Length ];

        for ( int i = 0 ; i < playerObjects . Length ; i++ )
        {
            playerTransforms [ i ] = playerObjects [ i ] . transform;
        }
    }

    void Update ( )
    {
        if ( playerTransforms != null && currentTargetIndex < playerTransforms . Length )
        {
            // Move towards the current player transform
            Transform targetTransform = playerTransforms[currentTargetIndex];
            Vector3 targetPosition = targetTransform.position;
            transform . position = Vector3 . MoveTowards (transform . position , targetPosition , moveSpeed * Time . deltaTime);

            // Check if we've reached the current target
            if ( transform . position == targetPosition )
            {
                // Move to the next target
                currentTargetIndex++;
            }
        }
        else
        {
            // Destroy the GameObject when all targets have been reached
            Destroy (gameObject);
        }
    }
}