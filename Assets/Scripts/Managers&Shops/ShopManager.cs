using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{


    public int goldAmount;
    public int Cost;

    public bool common;
    public bool noble;
    public bool king;
    public bool legends;


    public AudioClip coinSfx;
 
    public AudioClip chestSfx;

    public void OnPurchase()
    {
       
        
        if(GameManager.essence >= Cost)
        {
            SoundManager . Instance . PlaySound (coinSfx);
            GameManager.coins += goldAmount;
            GameManager . soulFire += (int)goldAmount  / 100;

            GameManager .essence -= Cost;
        }
        
    }

    public void LootGet()
    {

        if (common == true)
        {
            if(GameManager.coins >= Cost)
            {
                SoundManager . Instance . PlaySound (chestSfx);
                GameManager .coins -= Cost;
                GameManager.commonChest += 1;
            }
           
        }
        if (noble == true)
        {
            if (GameManager.coins >= Cost)
            {
                SoundManager . Instance . PlaySound (chestSfx);
                GameManager .coins -= Cost;
                GameManager.NobleChest += 1;
            }

        }
        if (king == true)
        {
            if (GameManager.coins >= Cost)
            {
                SoundManager . Instance . PlaySound (chestSfx);
                GameManager .coins -= Cost;
                GameManager.KingChest += 1;
            }

        }
        if (legends == true)
        {
            if (GameManager.coins >= Cost)
            {
                SoundManager . Instance . PlaySound (chestSfx);
                GameManager .coins -= Cost;
                GameManager.LegendChest += 1;
            }

        }
    }
}
