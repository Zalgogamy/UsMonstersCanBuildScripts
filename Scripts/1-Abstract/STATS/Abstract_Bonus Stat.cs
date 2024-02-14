using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Abstract_BonusStat : Basic_Stat
{
    [Header("Bonus")]
    public float BonusValue;
    public void UpdateBonusValue(int valueToUpdate) 
    {
        BonusValue += valueToUpdate;
    }
}
