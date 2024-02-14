using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Abstract_Building : Basic_Unit
{
    [Header("Stat")]
    public Abstact_LimitedStat MainStat;

    [Header("Building type")]
    public BuildingTag Type;
}
