using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellShards : MonoBehaviour
{
    public AudioClip sfx;
    public void Sell ( )
    {
        SoundManager . Instance . PlaySound (sfx);

        string classTag = gameObject.tag;
        HandleClassTags (classTag);


    }
    public void HandleClassTags ( string tag )
    {
        switch ( tag )
        {

            case "Cleric":
                GameManager . coins += GameManager . HireCleric * 3;
                GameManager . HireCleric -= GameManager . HireCleric; 
                break;
            case "Wizard":

                GameManager . coins += GameManager . HireWizard * 3;
                GameManager . HireWizard -= GameManager . HireWizard;
                break;
            case "Monk":

                GameManager . coins += GameManager . HireMonk * 12;
                GameManager . HireMonk -= GameManager . HireMonk;
                break;
            case "Druid":
                GameManager . coins += GameManager . HireDruid * 3;
                GameManager . HireDruid -= GameManager . HireDruid;
                break;
            case "Alchemist":
                GameManager . coins += GameManager . HireAlchemist * 12;
                GameManager . HireAlchemist -= GameManager . HireAlchemist;

                break;
            case "Rogue":

                GameManager . coins += GameManager . HireRogue * 3;
                GameManager . HireRogue -= GameManager . HireRogue;
                break;
            case "Paladin":

                GameManager . coins += GameManager . HirePaladin * 100;
                GameManager . HirePaladin -= GameManager . HirePaladin;
                break;
            case "Necromancer":

                GameManager . coins += GameManager . HireNecromancer * 100;
                GameManager . HireNecromancer -= GameManager . HireNecromancer;
                break;
            case "PlagueDoctor":

                GameManager . coins += GameManager . HirePlague * 12;
                GameManager . HirePlague -= GameManager .HirePlague;
                break;
            case "SpiritMaster":
                GameManager . coins += GameManager . HireMaster * 100;
                GameManager . HireMaster -= GameManager . HireMaster;

                break;
            case "Merchant":

                GameManager . coins += GameManager . HireMerchant * 12;
                GameManager . HireMerchant -= GameManager . HireMerchant;
                break;
            case "Candle":

                GameManager . coins += GameManager . HireCandle * 12;
                GameManager . HireCandle -= GameManager . HireCandle;
                break;
            case "Bard":

                GameManager . coins += GameManager . HireBard * 12;
                GameManager . HireBard -= GameManager . HireBard;
                break;
            case "Puppeteer":

                GameManager . coins += GameManager . HirePuppeteer * 100;
                GameManager . HirePuppeteer -= GameManager . HirePuppeteer;
                break;
            case "FortNight":

                GameManager . coins += GameManager . HireFortnight * 3;
                GameManager . HireFortnight -= GameManager . HireFortnight;
                break;
            default:

                break;
        }
    }
    
}
