using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Abstract_Town : Basic_Unit
{
    public Abstract_PlainStat EconomicPower;
    public Abstact_LimitedStat Food;
    public Abstact_LimitedStat InhabitantsCapacity;

    [Header("Town tag")]
    public CityTag TypeTag;
}
