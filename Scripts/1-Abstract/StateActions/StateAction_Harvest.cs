using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StateAction_Harvest : Basic_StateAction
{
    public Core_ResourceProducer targetProducer;
    public Core_PlayeableUnit TargetPlayeableUnit;
    public Core_Pathfinding pathfinding;

    public void GoToResource() 
    {
        pathfinding.move_Comp.TargetDestination = targetProducer.gameObject.transform.position;
        pathfinding.OnTheMove = true;
    }

    public override void ActionFunction()
    {
        TargetPlayeableUnit.SubscribeToProducer(targetProducer);
    }
}
