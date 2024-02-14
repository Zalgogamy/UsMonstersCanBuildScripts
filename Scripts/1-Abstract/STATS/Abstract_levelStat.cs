using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]public class Abstract_levelStat : Basic_Stat
{
    [Header("Levels")]
    public int currentLevel,maxLevel;
    [Header("experience")]
    public int currentXp;
    public int nextLevelModifier;
    public int requiredXp;
    [Header("bonus")]
    public float currentBonus;
    public float bonusScale;
}
