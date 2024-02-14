using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Abstract_PlainStat : Basic_Stat
{
    public void ModifyStat(float NewValue) 
    {
        StatValue = NewValue;
    }
}
