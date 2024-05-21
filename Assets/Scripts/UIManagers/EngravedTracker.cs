using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;

public class EngravedTracker : MonoBehaviour
{


    public Text critText;
    public Text armorText;
    public Text cosmoText;
    public Text uniqueText;
    public Text healText;
    public Text physicalText;
    public Text magicText;
    public Text summonText;
    // Start is called before the first frame update
    public bool full;

    // Update is called once per frame
    void Update()
    {
        if(full == true)
        {
            critText . text = ": " + GameManager . critChance1 . ToString ();
            armorText . text = ": " + GameManager . Armor1 . ToString ();
            cosmoText . text = ": " + GameManager . cosmo1 . ToString ();
            uniqueText . text = ": " + GameManager . unique1 . ToString ();
            healText . text = ": " + GameManager . healing1 . ToString ();
            physicalText . text = ": " + GameManager . physical1 . ToString ();

            magicText . text = ": " + GameManager . magic1 . ToString ();
            summonText . text = ": " + GameManager . summonPower1 . ToString ();

        }
        else
        {
            critText . text = GameManager . RUNEcritChance . ToString ();
            armorText . text = GameManager . RUNEArmor . ToString ();
            cosmoText . text = GameManager . RUNEcosmo . ToString ();
            uniqueText . text = GameManager . RUNEunique.ToString ();
            healText . text = GameManager . RUNEhealing . ToString ();
            physicalText . text = GameManager . RUNEphysical . ToString ();

            magicText . text = GameManager . RUNEmagic . ToString ();
            summonText . text = GameManager . RUNEsummon . ToString ();

        }


    }
}
