using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;

public class MapMenuShowEcl : MonoBehaviour
{

    public GameObject chests;
    public GameObject enchant;
    private void Update ( )
    {
        

        if(GameManager.commonChest + GameManager . NobleChest + GameManager . KingChest + GameManager . LegendChest >= 1)
        {
            chests . SetActive (true);
        }
        else
        {
            chests . SetActive (false);
        }


        if(GameManager.enchantChest >= 1)
        {
            enchant . SetActive (true);
        }
        else
        {
            enchant . SetActive (false);
        }
    }
}
