using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core_ActionManager : Basic_ComponentCore
{
    
    [Header("Actions")]
    public Action_Glosary Glosary;
    public Comunicatorstate ActionStatus;


    public void SetToMove() 
    {
        Debug.Log("Set To Move");
        SetSelectedTo(Comunicatorstate.Movement);

    }

    public void SetToCancel()
    {
        Debug.Log("Set To cancel");
        SetSelectedTo(Comunicatorstate.Cancel);

    }

    public void SetToMine()
    {
        Debug.Log("Set To Mine");
        SetSelectedTo(Comunicatorstate.WorkUnit);

    }

    public void SetToHunt()
    {
        Debug.Log("Set To hunt");
        SetSelectedTo(Comunicatorstate.Hunt);

    }

    public void SetToSpecial()
    {
        Debug.Log("Set To Special");
        SetSelectedTo(Comunicatorstate.Special);

    }



    public void SetSelectedTo(Comunicatorstate state) 
    {
        if (Comunicator.Selected_CoreUnit != null)
        {
            Comunicator.Selected_CoreUnit.Status = state;
            ActionStatus = state;
        }
        if (Comunicator.Selected_coreProducer != null)
        {
            Comunicator.Selected_coreProducer.Status = state;
            ActionStatus = state;
        }
        if (Comunicator.Selected_coreBuilding != null)
        {
            Comunicator.Selected_coreBuilding.Status = state;
            ActionStatus = state;
        }

        Comunicator.CheckState(ActionStatus);
    }

}
public enum Comunicatorstate{Movement,WorkUnit,WorkResource, Hunt,Special,Cancel,standby};

[System.Serializable]
public class Action_Glosary
{

    public StateAction_Move ActionMove;

    public StateAction_Harvest ActionHarvest;
}
