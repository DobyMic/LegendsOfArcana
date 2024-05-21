using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{

    public int shardBoostSave;
    public int reputationSave;
    public int essenceSave;
    public int soulFireSave;
    public int coinsSave;
    public int totalLootSave;
    public int WizardSave;
    public int ClericSave;
    public int MonkSave;
    public int RogueSave;
    public int AlchemistSave;
    public int DruidSave;
    public int PaladinSave;
    public int NecromancerSave;
    public int PlagueSave;
    public int MasterSave;
    public int MerchantSave;
    public int CandleSave;
    public int HireWizardSave;
    public int HireClericSave;
    public int HireMonkSave;
    public int HireRogueSave;
    public int HireAlchemistSave;
    public int HireDruidSave;
    public int HirePaladinSave;
    public int HireNecromancerSave;
    public int HirePlagueSave;
    public int HireMasterSave;
    public int HireMerchantSave;
    public int HireCandleSave;

    public int currentLevelSave;
    public int commonChestSave;
    public int NobleChestSave;
    public int KingChestSave;
    public int LegendChestSave;
    public int enchantChestSave;
    public int magicSave;
    public int healingSave;
    public int ArmorSave;
    public int physicalSave;
    public int summonPowerSave;
    public int uniqueSave;
    public int cosmoSave;
    public int critChanceSave;
    public int RUNEmagicSave;
    public int RUNEhealingSave;
    public int RUNEArmorSave;
    public int RUNEphysicalSave;
    public int RUNEsummonSave;
    public int RUNEuniqueSave;
    public int RUNEcosmoSave;
    public int RUNEcritChanceSave;
    public int BardSave;
    public int PuppeteerSave;
    public int FortnightSave;
    public int HireBardSave;
    public int HirePuppeteerSave;
    public int HireFortnightSave;
    public int maxNgSave;
    public int currentNgSave;
    public int beginnerLvlSave;



    public PlayerData ( )
    {
  
        shardBoostSave = GameManager . shardBoost;
        reputationSave = GameManager . reputation;
        essenceSave = GameManager . essence;
        soulFireSave = GameManager . soulFire;
        coinsSave = GameManager . coins;

        WizardSave = GameManager . Wizard;
        ClericSave = GameManager . Cleric;
        MonkSave = GameManager . Monk;
        RogueSave = GameManager . Rogue;
        AlchemistSave = GameManager . Alchemist;
        DruidSave = GameManager . Druid;
        PaladinSave = GameManager . Paladin;
        NecromancerSave = GameManager . Necromancer;
        PlagueSave = GameManager . Plague;
        MasterSave = GameManager . Master;
        MerchantSave = GameManager . Merchant;
        CandleSave = GameManager . Candle;
        HireWizardSave = GameManager . HireWizard;
        HireClericSave = GameManager . HireCleric;
        HireMonkSave = GameManager . HireMonk;
        HireRogueSave = GameManager . HireRogue;
        HireAlchemistSave = GameManager . HireAlchemist;
        HireDruidSave = GameManager . HireDruid;
        HirePaladinSave = GameManager . HirePaladin;
        HireNecromancerSave = GameManager . HireNecromancer;
        HirePlagueSave = GameManager . HirePlague;
        HireMasterSave = GameManager . HireMaster;
        HireMerchantSave = GameManager . HireMerchant;
        HireCandleSave = GameManager . HireCandle;
  
        currentLevelSave = GameManager . currentLevel;
        commonChestSave = GameManager . commonChest;
        NobleChestSave = GameManager . NobleChest;
        KingChestSave = GameManager . KingChest;
        LegendChestSave = GameManager . LegendChest;
        enchantChestSave = GameManager . enchantChest;
        magicSave = GameManager . magic1;
        healingSave = GameManager . healing1;
        ArmorSave = GameManager . Armor1;
        physicalSave = GameManager . physical1;
        summonPowerSave = GameManager . summonPower1;
        uniqueSave = GameManager . unique1;
        cosmoSave = GameManager . cosmo1;
        critChanceSave = GameManager . critChance1;
        RUNEmagicSave = GameManager . RUNEmagic;
        RUNEhealingSave = GameManager . RUNEhealing;
        RUNEArmorSave = GameManager . RUNEArmor;
        RUNEphysicalSave = GameManager . RUNEphysical;
        RUNEsummonSave = GameManager . RUNEsummon;
        RUNEuniqueSave = GameManager . RUNEunique;
        RUNEcosmoSave = GameManager . RUNEcosmo;
        RUNEcritChanceSave = GameManager . RUNEcritChance;
        PuppeteerSave = GameManager . Puppeteer;
        BardSave = GameManager . Bard;
        FortnightSave = GameManager . Fortnight;
        HireBardSave = GameManager . HireBard;
        HirePuppeteerSave = GameManager . HirePuppeteer;
        HireFortnightSave = GameManager . HireFortnight;
        currentNgSave = GameManager . currentNG;
        maxNgSave = GameManager . maxNG;
        beginnerLvlSave = GameManager . beginnerLvl;
    }

  










}
