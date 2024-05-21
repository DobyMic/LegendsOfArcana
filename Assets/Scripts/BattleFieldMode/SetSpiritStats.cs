using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpiritStats : MonoBehaviour
{
    public bool legend;
    private int uniqueAffect;
    
    // Start is called before the first frame update
    void Awake()
    {

        uniqueAffect = (int)Random . Range (1 , 5);

        

        if(legend  == true)
        {
            var AI1 =  gameObject . GetComponent<LegendAI> ();
            var AI1Move = gameObject.GetComponent<LegendMove>();

            AI1 . attackDamage = ( int ) Random . Range (1 , 100);
            AI1 . attackInterval = Random . Range (0.5f , 10);
            AI1 . attackRange = Random . Range (0.5f , 20);
            AI1Move . minDistanceToEnemy = AI1 . attackRange;
            AI1Move . moveSpeed =  Random . Range (1 , 30);
            AI1Move . startspeed = AI1Move . moveSpeed;

            switch ( uniqueAffect )
            {

                case 1:
                    AI1 . freezing = true;
                    break;

                case 2:

                    break;

                case 3:
                    AI1 . poison = true;
                    break;

                case 4:
                    
                    break;

                case 5:

                    break;

            }


        }
        else
        {

            var AI2 = gameObject . GetComponent<Enemy> ();
            var AI2Move = gameObject.GetComponent<EnemyMove>();

            AI2 . attackDamage = ( int ) Random . Range (1 , 100);
            AI2 . attackInterval = Random . Range (0.5f , 12);
            AI2 . attackRange = Random . Range (0.5f , 20);
            AI2Move . minDistanceToEnemy = AI2 . attackRange;
            AI2Move . moveSpeed = Random . Range (1 , 30);
            AI2Move . startspeed = AI2Move . moveSpeed;

            switch ( uniqueAffect )
            {

                case 1:
                 
                    break;

                case 2:
                    AI2 . LifeSteal = true;
                    break;

                case 3:
                    AI2 . poison = true;
                    break;

                case 4:
                    
                    break;

                case 5:

                    break;

            }
        }


        var Hp = gameObject.GetComponent<Health>();


        Hp . maxHealth = (int)Random . Range (1 , 300);
        Hp . currentHealth = Hp . maxHealth;


     





    }


}
