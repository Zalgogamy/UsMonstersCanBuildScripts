using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Abstract_MoveTowards : Basic_Move
{
    public GameObject TargetMover;
    public Vector3 TargetDestination;
    public float distance, arrivalDistance;
    public bool InDistance,distanceSet;

    public void ModifyDirection() 
    {
        CheckDistance();
        if (!distanceSet)
        {
            Basic_action_Move(TargetDestination);
            distanceSet = true;
        }
    }

    public void CheckDistance() 
    {
        distance = Vector3.Distance(TargetDestination, TargetMover.transform.position);

        if (distance <= arrivalDistance) 
        {
            InDistance = true;
        }
        else
        {
            InDistance = false;
        }

    }

    public void StopMovement() 
    {
        Basic_action_Move(TargetDestination);
        distanceSet = false;
        CheckDistance();
    }

}
