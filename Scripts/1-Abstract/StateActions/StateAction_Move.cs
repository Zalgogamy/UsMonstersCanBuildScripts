using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StateAction_Move : Basic_StateAction
{
    public Core_Pathfinding Pathfinder;
    public Vector3 PositionToMove;
    public void Getdestination() 
    {
        Pathfinder.move_Comp.TargetDestination = PositionToMove;
    }
    public override void ActionFunction()
    {
        Getdestination();
        Pathfinder.OnTheMove = true;
    }
}
