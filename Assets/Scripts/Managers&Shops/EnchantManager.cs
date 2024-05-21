using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;

public class EnchantManager : MonoBehaviour
{
    public int Cost;

    public bool magicClover;

    public bool physicalClover;
    public bool healingClover;
    public bool SummonClover;
    public bool cosmoClover;
    public bool chestenchant;


    public AudioClip runeCraft;

  
    public void LootGet ( )
    {
        SoundManager . Instance . PlaySound (runeCraft);

        if ( magicClover == true )
        {
            if ( GameManager . reputation >= Cost )
            {
                GameManager . reputation -= Cost;
                GameManager . RUNEmagic += 1;
            }

        }
        if ( physicalClover == true )
        {
            if ( GameManager . reputation >= Cost )
            {
                GameManager . reputation -= Cost;
                GameManager . RUNEphysical += 1;
            }

        }
        if ( healingClover == true )
        {
            if ( GameManager . reputation >= Cost )
            {
                GameManager . reputation -= Cost;
                GameManager . RUNEhealing += 1;
            }

        }
        if ( SummonClover == true )
        {
            if ( GameManager . reputation >= Cost )
            {
                GameManager . reputation -= Cost;
                GameManager . RUNEsummon += 1;
            }

        }

        if ( cosmoClover == true )
        {
            if ( GameManager . reputation >= Cost )
            {
                GameManager . reputation -= Cost;
                GameManager . RUNEcosmo += 1;
            }

        }
        if ( chestenchant == true )
        {
            if ( GameManager . reputation >= Cost )
            {
                GameManager . reputation -= Cost;
                GameManager . enchantChest += 1;
            }

        }

    }
}
