using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Basic_Stat 
{
    [Header("Name and description")]
    public string StatName;
    [TextArea]
    public string StatDescription;
    [Header("base value")]
    public float StatValue;
}
