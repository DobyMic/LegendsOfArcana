using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;

public class EngraveRune : MonoBehaviour
{
    public int Cost;



    public AudioClip craftSfx;
  

    public void LootGetPhysical()
    {
        if ( GameManager . RUNEphysical >= 1 )
        {
            if ( GameManager . essence >= Cost )
            {

                SoundManager . Instance . PlaySound (craftSfx);
                GameManager . essence -= Cost;
                GameManager . RUNEphysical -= 1;
                GameManager . physical1 += 1;
            }
        }
    }

    public void LootGetSummon()
    {
        if ( GameManager . RUNEsummon >= 1 )
        {
            if ( GameManager . essence >= Cost )
            {

                SoundManager . Instance . PlaySound (craftSfx);
                GameManager . essence -= Cost;
                GameManager . RUNEsummon -= 1;
                GameManager . summonPower1 += 1;
            }
        }
    }

    public void LootGetHeal()
    {
        if ( GameManager . RUNEhealing >= 1 )
        {
            if ( GameManager . essence >= Cost )
            {

                SoundManager . Instance . PlaySound (craftSfx);
                GameManager . essence -= Cost;
                GameManager . RUNEhealing -= 1;
                GameManager . healing1 += 1;
            }
        }
    }

    public void LootGetCrit()
    {

        if ( GameManager . RUNEcritChance >= 1 )
        {
            if ( GameManager . essence >= Cost )
            {

                SoundManager . Instance . PlaySound (craftSfx);
                GameManager . essence -= Cost;
                GameManager . RUNEcritChance -= 1;
                GameManager . critChance1 += 1;
            }
        }

    }


    public void LootGetArmor()
    {
        if ( GameManager . RUNEArmor >= 1 )
        {
            if ( GameManager . essence >= Cost )
            {

                SoundManager . Instance . PlaySound (craftSfx);
                GameManager . essence -= Cost;
                GameManager . RUNEArmor -= 1;
                GameManager . Armor1 += 1;
            }
        }
    }

    public void LootGetUnique()
    {

        if ( GameManager . RUNEunique >= 1 )
        {
            if ( GameManager . essence >= Cost )
            {

                SoundManager . Instance . PlaySound (craftSfx);
                GameManager . essence -= Cost;
                GameManager . RUNEunique -= 1;
                GameManager . unique1 += 1;
            }
        }
    }


    public void LootGetCosmo()
    {

        if ( GameManager . RUNEcosmo >= 1 )
        {
           
            if ( GameManager . essence >= Cost )
            {

           
                SoundManager . Instance . PlaySound (craftSfx);
                GameManager . essence -= Cost;
                GameManager . RUNEcosmo -= 1;
                GameManager . cosmo1 += 1;

            }
        }
    }
    public void LootGetMagic ( )
    {

        
            if (GameManager.RUNEmagic >= 1)
            {
                if ( GameManager . essence >= Cost )
                {

                    SoundManager . Instance . PlaySound (craftSfx);
               
                    GameManager . essence -= Cost;
                    GameManager . RUNEmagic -= 1;
                    GameManager . magic1 += 1;
                }
            }

    }
}
