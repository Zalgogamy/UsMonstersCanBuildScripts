using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Basic_Unit 
{
    [Header("Rp variables")]
    public string UnitName, UnitSurname;

}
public enum UnitRaces {Goblin,Kobold,Slime,Skelleton,Gnome,Merfolk,Ogre,pixie,drider,elemental,Human};
public enum CityTag {Outpost, Stlement, Village};
public enum BuildingTag { house,silo };

public enum producerTag {Mining,harvesting,crafting};
