using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Abstract_ResourceProducer : Basic_Unit
{
    [Header("STATS")]
    public Abstact_LimitedStat ItemPoolCapacity;
    public Abstact_LimitedStat Progress;

    [Header("Items")]
    public Template_resource[] ItemPool;


}
