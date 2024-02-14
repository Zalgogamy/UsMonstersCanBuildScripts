using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Abstract_PlayeableUnit : Basic_Unit
{
    [Header("Race")]
    public UnitRaces race;

    [Header("Basic Stats")]
    public Abstract_PlainStat Life;

    public Abstract_PlainStat Magic;

    public Abstract_BonusStat InventorySize;


    [Header("Work Stats")]

    public Abstract_BonusStat HarvestSpeed;

    public Abstract_BonusStat MiningSpeed;

    public Abstract_BonusStat ResearchSpeed;

    public Abstract_BonusStat BuildingSpeed;

    public Abstract_BonusStat CraftingSpeed;

    public Abstract_PlainStat Workforce;


    [Header("Combat Stats")]
    public Abstract_BonusStat CombatSpeed;

    //accuraccy = weapon accuracy + accesory accuracy
    public Abstract_PlainStat Accuracy;

    //defense = armor value
    public Abstract_BonusStat defense;

}
