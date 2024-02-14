using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Abstract_LeaderUnit : Basic_Unit
{
    [Header("Leader Stats")]
    public Abstract_levelStat Technology;
    public Abstract_levelStat MarketInfluence;
    public Abstract_levelStat Charisma;
    [Header("Race")]
    public UnitRaces race;
}
