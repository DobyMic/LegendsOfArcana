using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;

public class CardInfo : MonoBehaviour
{


    public int AtkStat;
    public int HpStat;
    public float AtkSpeed;
    public int critStat;
    public float SpeedStat;
    public float rangeStat;
    public string info;

    public bool physical;
    public bool crit;
    public bool armor;
    public bool unique;
    public bool magic;
    public bool healing;
    public bool summon;


    public Text atkText;
    public Text HpText;
    public Text atkSpeedText;
    public Text critText;
    public Text speedText;
    public Text rangeText;
    public Text infoText;


    

    // Start is called before the first frame update
    void Start()
    {


        atkSpeedText . text = AtkSpeed.ToString();
        speedText . text = SpeedStat . ToString ();
        rangeText . text = rangeStat . ToString ();
        infoText . text = info . ToString ();







        HpStat += GameManager . cosmo1;
        critStat += GameManager . cosmo1;

        int atkVars = 0;
        if(armor == true)
        {
            HpText . text = HpStat . ToString () + "(x" + GameManager.Armor1 + ")";
        }
        else
        {
            HpText . text = HpStat . ToString ();

        }


        critStat += GameManager . cosmo1;

        if(crit == true)
        {
            critText . text = critStat . ToString () + "(x" + GameManager . critChance1 + ")";
            atkVars += GameManager . critChance1;
        }
        else
        {
            critText . text = critStat . ToString ();
        }

        if(physical == true)
        {
            atkVars += GameManager . physical1;
        }
        if ( healing == true )
        {
            atkVars += GameManager . healing1;
        }

        if ( summon == true )
        {
            atkVars += GameManager . summonPower1;
        }
        if ( unique == true )
        {
            atkVars += GameManager . unique1;
        }
        if ( magic == true )
        {
            atkVars += GameManager . magic1;
        }

        
        atkText.text = AtkStat + GameManager . cosmo1 + "(x" + atkVars + ")";





    }

 

    // Update is called once per frame
    void Update()
    {
        
    }
}
