using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[System.Serializable]
public abstract class Basic_Move 
{
    public NavMeshAgent MoverAgent;   

    public void Basic_action_Move(Vector3 Destination) 
    {
        MoverAgent.SetDestination(Destination);
        //MoverAgent.Move(Destination);
    }
}
