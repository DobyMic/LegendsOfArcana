using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public float saveTimer = 6f;


    private float prevEssence;
    private float prevCoin;
    private float prevFire;

    private float prevRep;


  

    public Text essenceText;
    public Text coinsText;
    public Text LootText;
    public Text rankText;
    public Text RepText;
    public Text fireText;


    public static int shardBoost = 40;

    public static int maxNG = 1;
    public static int currentNG = 0;



    public static int reputation;

    public static int essence;
    public static int soulFire;


    public static int coins;


    public static int Wizard = 0;
    public static int Cleric = 0;
    public static int Monk = 0;
    public static int Rogue = 0;
    public static int Alchemist = 0;
    public static int Druid = 0;
    public static int Paladin = 0;
    public static int Necromancer = 0;
    public static int Plague = 0;
    public static int Master = 0;
    public static int Merchant = 0;
    public static int Candle = 0;
    public static int Bard = 0;
    public static int Puppeteer = 0;
    public static int Fortnight = 0;

    public static int HireWizard = 0;
    public static int HireCleric = 0;
    public static int HireMonk = 0;
    public static int HireRogue = 0;
    public static int HireAlchemist = 0;
    public static int HireDruid = 0;
    public static int HirePaladin = 0;
    public static int HireNecromancer = 0;
    public static int HirePlague = 0;
    public static int HireMaster = 0;
    public static int HireMerchant = 0;
    public static int HireCandle = 0;
    public static int HireBard = 0;
    public static int HirePuppeteer = 0;
    public static int HireFortnight = 0;



    public static int currentLevel = 1;


    public static int commonChest = 0;
    public static int NobleChest = 0;
    public static int KingChest = 0;
    public static int LegendChest = 0;




    public static int enchantChest = 0;

    public static int magic1 = 1;
    public static int healing1 = 1;
    public static int Armor1 = 1;
    public static int physical1 = 1;
    public static int summonPower1 = 1;
    public static int unique1 = 1;
    public static int cosmo1 = 0;

    public static int critChance1 = 0;

    public static int RUNEmagic = 0;
    public static int RUNEhealing = 0;
    public static int RUNEArmor = 0;
    public static int RUNEphysical = 0;
    public static int RUNEsummon = 0;
    public static int RUNEunique = 0;
    public static int RUNEcosmo = 0;
    public static int RUNEcritChance = 0;

    public static int regionSel;

    public static bool allForOne;


    private float prevEnchant;
    private float prevChest;
    private float prevRune;
    private float prevLegend;

    private float totalLegends;

    public GameObject enchantChestPopup;
    public GameObject legendPopup;
    public GameObject chestPopup;
    public GameObject runePopup;




    public static bool teamLava;
    public static bool teamWhisp;





    public static int revealProceed;
    public static int resourceType;

    public static int whispsDead;
    public static int ballsDead;

    public static int beginnerLvl = 0;
    


    public GameObject loading1,loading2,loading3,loading4,loading5;

    public void SavePlayer()
    {
        SaveSystem . SavePlayer ();
    }

    
    public void LoadPlayer ()
    {

        SaveSystem . LoadPlayer ();
        PlayerData data = SaveSystem.LoadPlayer();


   
        shardBoost = data . shardBoostSave;

        reputation = data . reputationSave;

        essence = data . essenceSave;
        soulFire = data . soulFireSave;

        coins = data . coinsSave;

    

        Wizard = data . WizardSave;
        Cleric = data . ClericSave;
        Monk = data . MonkSave;
        Rogue = data . RogueSave;
        Alchemist = data . AlchemistSave;
        Druid = data . DruidSave;
        Paladin = data . PaladinSave;
        Necromancer = data . NecromancerSave;
        Plague = data . PlagueSave;
        Master = data . MasterSave;
        Merchant = data . MerchantSave;
        Candle = data . CandleSave;

        HireWizard = data . HireWizardSave;
        HireCleric = data . HireClericSave;
        HireMonk = data . HireMonkSave;
        HireRogue = data . HireRogueSave;
        HireAlchemist = data . HireAlchemistSave;
        HireDruid = data . HireDruidSave;
        HirePaladin = data . HirePaladinSave;
        HireNecromancer = data . HireNecromancerSave;
        HirePlague = data . HirePlagueSave;
        HireMaster = data . HireMasterSave;
        HireMerchant = data . HireMerchantSave;
        HireCandle = data . HireCandleSave;
        HireBard = data . HireBardSave;
        HirePuppeteer = data . HirePuppeteerSave;
        HireFortnight = data . HireFortnightSave;
        Bard = data . BardSave;
        Puppeteer = data . PuppeteerSave;
        Fortnight = data . FortnightSave;

     

        currentLevel = data . currentLevelSave;

        commonChest = data . commonChestSave;
        NobleChest = data . NobleChestSave;
        KingChest = data . KingChestSave;
        LegendChest = data . LegendChestSave;

        enchantChest = data . enchantChestSave;

        magic1 = data . magicSave;
        healing1 = data . healingSave;
        Armor1 = data . ArmorSave;
        physical1 = data . physicalSave;
        summonPower1 = data . summonPowerSave;
        unique1 = data . uniqueSave;
        cosmo1 = data . cosmoSave;

        critChance1 = data . critChanceSave;

        RUNEmagic = data . RUNEmagicSave;
        RUNEhealing = data . RUNEhealingSave;
        RUNEArmor = data . RUNEArmorSave;
        RUNEphysical = data . RUNEphysicalSave;
        RUNEsummon = data . RUNEsummonSave;
        RUNEunique = data . RUNEuniqueSave;
        RUNEcosmo = data . RUNEcosmoSave;
        RUNEcritChance = data . RUNEcritChanceSave;

        maxNG = data . maxNgSave;
        currentNG = data . currentNgSave;
        beginnerLvl = data . beginnerLvlSave;
    }

    // Start is called before the first frame update




    private void OnApplicationQuit ( )
    {
        SavePlayer ();
    }


    private void Awake ( )
    {


        DontDestroyOnLoad (this . gameObject);
        LoadPlayer();
        if ( Instance == null )
        {
            Instance = this;
            DontDestroyOnLoad (gameObject);

        }
        else
        {
            Destroy (gameObject);
        }

    }

    private void Start ( )
    {
        prevRep = reputation;
        prevCoin = coins;
        prevEssence = essence;
        prevFire = soulFire;
 
        prevLegend = Puppeteer + Master + Necromancer + Paladin + Alchemist + Merchant + Candle + Monk + Bard + Plague + Cleric + Fortnight + Wizard + Rogue + Druid;
        totalLegends = Puppeteer + Master + Necromancer + Paladin + Alchemist + Merchant + Candle + Monk + Bard + Plague + Cleric + Fortnight + Wizard + Rogue + Druid;
        prevChest = commonChest + NobleChest + KingChest + LegendChest;
        prevRune = cosmo1 + unique1 + critChance1 + Armor1 + summonPower1 + physical1 + magic1 + healing1;
        prevEnchant = enchantChest;
    }


    // Update is called once per frame
    void Update()
    {
        totalLegends = Puppeteer + Master + Necromancer + Paladin + Alchemist + Merchant + Candle + Monk + Bard + Plague + Cleric + Fortnight + Wizard + Rogue + Druid;
        Debug . Log (currentLevel);
   
     

        if (coins >= 1000000)
        {
            coinsText . text = ": " + (int)prevCoin / 1000000 + "M";
        }
        else
        {
            coinsText . text = ": " + prevCoin . ToString ("F0");
        }

        if ( essence >= 1000000 )
        {
            essenceText . text = ": " + (int)prevEssence / 1000000 + "M";

        }
        else
        {
            essenceText . text = ": " + prevEssence . ToString ("F0");

        }


        if ( soulFire >= 1000 )
        {
            fireText . text = ": " + (int)prevFire / 1000 + "K";

        }
        else
        {
            fireText . text = ": " + prevFire . ToString ("F0");
        }


        if ( reputation >= 1000000 )
        {

            RepText . text = ": " + (int)prevRep / 1000000 + "M";
        }
        else
        {
            RepText . text = ": " + prevRep . ToString ("F0");
        }



        rankText . text = " : " + currentNG . ToString ();


        LootText.text = ": " + currentLevel.ToString();
     

 
      
        

        OverCard ();
        
        saveTimer -= Time.deltaTime;
        if(saveTimer <= 0)
        {

            SavePlayer();
            saveTimer = 10;
        }

        //SavePlayer ();


        OnCurrencyChanged ();
        OnGainItem ();
      
    }

   

    public void resetAcc()
    {
        shardBoost = 40;

        reputation = 0;

        essence = 0;
        soulFire = 0;

        coins = 0;



        Wizard = 0;
        Cleric = 0;
        Monk = 0;
        Rogue = 0;
        Alchemist = 0;
        Druid = 0;
        Paladin = 0;
        Necromancer = 0;
        Plague = 0;
        Master = 0;
        Merchant = 0;
        Candle = 0;

        HireWizard = 0;
        HireCleric = 0;
        HireMonk = 0;
        HireRogue = 0;
        HireAlchemist = 0;
        HireDruid = 0;
        HirePaladin = 0;
        HireNecromancer = 0;
        HirePlague = 0;
        HireMaster = 0;
        HireMerchant = 0;
        HireCandle = 0;
        HireBard = 0;
        HirePuppeteer = 0;
        HireFortnight = 0;
        Bard = 0;
        Puppeteer = 0;
        Fortnight = 0;



        currentLevel = 1;

        commonChest = 0;
        NobleChest = 0;
        KingChest = 0;
        LegendChest = 0;

        enchantChest = 0;

        magic1 = 1;
        healing1 = 1;
        Armor1 = 1;
        physical1 = 1;
        summonPower1 = 1;
        unique1 = 1;
        cosmo1 = 0;

        critChance1 = 1;

        RUNEmagic = 0;
        RUNEhealing = 0;
        RUNEArmor = 0;
        RUNEphysical = 0;
        RUNEsummon = 0;
        RUNEunique = 0;
        RUNEcosmo = 0;
        RUNEcritChance = 0;
        beginnerLvl = 0;

        maxNG = 1;
        currentNG = 0;
        beginnerLvl = 0;



        SaveSystem . DeleteSaveData ();
        Application . Quit ();
    }
    void OnCurrencyChanged()
    {

        if ( coins != prevCoin )
        {
            float coinEffect = coins - prevCoin;
     
            prevCoin += coinEffect * Time . deltaTime * 2;
         
        }


        if ( essence != prevEssence )
        {

            float essenceAffect = essence - prevEssence;

            prevEssence += essenceAffect * Time . deltaTime * 2;

        }

        if ( prevFire != soulFire )
        {
            float fireEffect = soulFire - prevFire;
       
            prevFire  += fireEffect * Time . deltaTime * 2;
        }

      

        if(prevRep != reputation)
        {

            float repEffect = reputation - prevRep;

            prevRep += repEffect * Time . deltaTime * 2;
            
        }
    }



    void OnGainItem()
    {
    

        if ( prevLegend != totalLegends )
        {
            Instantiate (legendPopup ,transform . position , Quaternion . identity);
            prevLegend = totalLegends;
        }
        int totalChest = commonChest + NobleChest + KingChest + LegendChest;

        if(prevChest != totalChest)
        {
            Instantiate (chestPopup ,transform . position , Quaternion . identity);
            prevChest = totalChest;
        }

        if(prevEnchant != enchantChest)
        {
            Instantiate (enchantChestPopup , transform . position , Quaternion . identity);
            prevEnchant = enchantChest;
        }

        int totalRune =  cosmo1 + unique1 + critChance1 + Armor1 + summonPower1 + physical1 + magic1 + healing1;

        if(prevRune != totalRune)
        {
            Instantiate (runePopup , transform . position , Quaternion . identity);
            prevRune = totalRune;
        }

 
    }
    
    void OverCard()
    {

        if(shardBoost <= 0)
        {
            shardBoost = 0;
        }
     
        if(Rogue >= 2)
        {
            cosmo1 += 1;
            
            Rogue = 1;
        }
        if ( Cleric >= 2 )
        {
            cosmo1 += 1;
            Cleric = 1;
        }
        if ( Wizard >= 2 )
        {
            cosmo1 += 1;
            Wizard = 1;
        }
        if ( Druid >= 2 )
        {
            cosmo1 += 1;
            Druid = 1;
        }
        if ( Alchemist >= 2 )
        {
            cosmo1 += 3;
            Alchemist = 1;
        }
        if ( Plague >= 2 )
        {
            cosmo1 += 3;
            Plague = 1;
        }
        if ( Monk >= 2 )
        {
            cosmo1 += 3;
            Monk = 1;
        }
        if ( Merchant >= 2 )
        {
            cosmo1 += 3;
            Merchant = 1;
        }
        if ( Candle >= 2 )
        {
            cosmo1 += 3; 
            Candle = 1;
        }
        if ( Paladin >= 2 )
        {
            cosmo1 += 12;
            Paladin = 1;
        }
        if ( Necromancer>= 2 )
        {
            cosmo1 += 12;
            Necromancer = 1;
        }
        if ( Master >= 2 )
        {
            cosmo1 += 12;
            Master = 1;
        }
        if ( Bard >= 2 )
        {
            cosmo1 += 3;
            Bard = 1;
        }
        if ( Puppeteer >= 2 )
        {
            cosmo1 += 12;
            Puppeteer = 1;
        }
        if ( Fortnight >= 2 )
        {
            cosmo1 += 1;
            Fortnight = 1;
        }







    }

}
