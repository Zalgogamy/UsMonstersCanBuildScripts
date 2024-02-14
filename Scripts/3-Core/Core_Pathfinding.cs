using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core_Pathfinding : MonoBehaviour
{

    public Vector2 direction;
    public float Range;
    public Abstract_MoveTowards move_Comp;
    public bool OnTheMove;

    


    private void Update()
    {
        if (OnTheMove)
        {

            Debug.Log("moving?");
           
            move_Comp.CheckDistance();

            if (move_Comp.InDistance)
            {
                Debug.Log("in distance, so no");
                OnTheMove = false;
                move_Comp.StopMovement();
                return;
            }
            Debug.Log("moving");
            move_Comp.ModifyDirection();


        }
    }


}
