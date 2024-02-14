using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Basic_StateAction 
{
    public string ActionName;
    public bool AviableAction;
    public abstract void ActionFunction();
}

