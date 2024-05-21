using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;


public class HireLegend : MonoBehaviour
{
    public Text amtText;
    public float fillValue;
    public Image fillImage;
    public Slider slider;
   

    public int Cost;

    public int shardReq;

    public bool monk1;
    public bool merchant1;
    public bool candle1;
    public bool alchemist1;
    public bool plague1;
    public bool druid1;
    public bool rogue1;
    public bool wizard1;
    public bool cleric1;
    public bool paladin1;
    public bool thresh1;
    public bool oogway1;
    public bool bard1;
    public bool puppeteer1;
    public bool fortnight1;

    public AudioClip craftLegendSfx;


    public void Start ( )
    {
        slider = GetComponent<Slider> ();
        slider . maxValue = shardReq;
    }

    public void Update ( )
    {
        


        if (monk1 == true)
        {
            fillValue = GameManager . HireMonk;
        }
        if ( alchemist1 == true )
        {
            fillValue = GameManager . HireAlchemist;
        }
        if ( merchant1 == true )
        {
            fillValue = GameManager . HireMerchant;
        }
        if ( plague1 == true )
        {
            fillValue = GameManager . HirePlague;
        }
        if (candle1 == true)
        {
            fillValue = GameManager . HireCandle;
        }
        if ( druid1 == true )
        {
            fillValue = GameManager . HireDruid;
        }
        if ( rogue1 == true )
        {
            fillValue = GameManager . HireRogue;
        }
        if ( wizard1 == true )
        {
            fillValue = GameManager . HireWizard;
        }
        if ( cleric1 == true )
        {
            fillValue = GameManager . HireCleric;
        }
        if ( thresh1 == true )
        {
            fillValue = GameManager . HireNecromancer;
        }
        if ( oogway1 == true )
        {
            fillValue = GameManager . HireMaster;
        }
        if ( paladin1 == true )
        {
            fillValue = GameManager . HirePaladin;
        }
        if ( bard1 == true )
        {
            fillValue = GameManager . HireBard;
        }
        if ( fortnight1 == true )
        {
            fillValue = GameManager . HireFortnight;
        }
        if ( puppeteer1 == true )
        {
            fillValue = GameManager . HirePuppeteer;
        }



        slider . value = fillValue;
        amtText . text = fillValue + "/" + shardReq.ToString();
        if ( slider . value <= slider . minValue )
        {
            fillImage . enabled = false;
            //Destroy (gameObject);
        }

        if ( slider . value > slider . minValue && !fillImage . enabled )
        {

            fillImage . enabled = true;
        }
    }


    public void hireLegend ( )
    {
        if ( monk1 == true )
        {
            if ( GameManager . HireMonk >= 1 )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireMonk -= 1;
                    GameManager . Monk += 1;
                }
            }



        }
        if ( merchant1 == true )
        {
            if ( GameManager. HireMerchant >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireMerchant -= shardReq;
                    GameManager . Merchant += 1;
                }
            }
        }
        if ( candle1 == true )
        {
            if ( GameManager . HireCandle >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireCandle -= shardReq;
                    GameManager . Candle += 1;
                }
            }
        }
        if ( alchemist1 == true )
        {
            if ( GameManager .HireAlchemist >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireAlchemist -= shardReq;
                    GameManager . Alchemist += 1;
                }
            }
        }

        if ( plague1 == true )
        {
            if ( GameManager . HirePlague >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HirePlague -= shardReq;
                    GameManager . Plague += 1;
                }
            }
        }

        if ( druid1 == true )
        {
            if ( GameManager . HireDruid >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireDruid -= shardReq;
                    GameManager . Druid += 1;
                }
            }
        }

        if ( rogue1 == true )
        {
            if ( GameManager . HireRogue >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireRogue -= shardReq;
                    GameManager . Rogue += 1;
                }
            }
        }
        if ( wizard1 == true )
        {
            if ( GameManager . HireWizard >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireWizard -= shardReq;
                    GameManager . Wizard+= 1;
                }
            }
        }
        if ( cleric1 == true )
        {
            if ( GameManager . HireCleric >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireCleric -= shardReq;
                    GameManager . Cleric += 1;
                }
            }
        }
        if ( paladin1 == true )
        {
            if ( GameManager . HirePaladin >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HirePaladin -= shardReq;
                    GameManager . Paladin += 1;
                }
            }
        }
        if ( thresh1 == true )
        {
            if ( GameManager . HireNecromancer >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireNecromancer -= shardReq;
                    GameManager . Necromancer += 1;
                }
            }
        }
        if ( oogway1 == true )
        {
            if ( GameManager . HireMaster>= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireMaster -= shardReq;
                    GameManager . Master += 1;
                }
            }
        }
        if ( bard1 == true )
        {
            if ( GameManager . HireBard >= 1 )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireBard -= shardReq;
                    GameManager . Bard += 1;
                }
            }
        }
        if ( puppeteer1 == true )
        {
            if ( GameManager . HirePuppeteer >= shardReq )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HirePuppeteer -= shardReq;
                    GameManager . Puppeteer += 1;
                }
            }
        }
        if ( fortnight1 == true )
        {
            if ( GameManager . HireFortnight >= 1 )
            {
                if ( GameManager . soulFire >= Cost )
                {
                    SoundManager . Instance . PlaySound (craftLegendSfx);
                    GameManager . soulFire -= Cost;
                    GameManager . HireFortnight -= shardReq;
                    GameManager . Fortnight += 1;
                }
            }
        }



    }
}
