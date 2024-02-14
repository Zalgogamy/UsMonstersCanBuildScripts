using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core_PlayeableUnit : Basic_SelectableCore
{
    public Abstract_PlayeableUnit UnitProfile;
    public Core_Pathfinding pathfinder_comp;
    public Abstract_AnimatorSate Animator_comp;
    public Core_ResourceProducer SubsribedProducer;
    

    [Header("Attachments")]

    public Template_Weapon EquipedWeapon;

    public Template_Armor EquipedArmor;

    public Template_Accesory EquipedAccesoy;

    [Header("Inventory")]

    public List<ScriptableObject> WorkInventory = new List<ScriptableObject>();

    [Header("Subscriptions")]
    public Core_ResourceProducer SubscribedProducer;
    //building
    //research
    //crafting
    public bool Ocupied,progressPoint;

    private void Update()
    {
        checkProducer();
        PerformWork();
        checkWalkAnims();
    }


    public void checkWalkAnims() 
    {
        if (pathfinder_comp.OnTheMove)
        {
            Animator_comp.PlayClip(Animator_comp.clips[0]);
        }
        if (Status == Comunicatorstate.standby || Status == Comunicatorstate.Movement && !pathfinder_comp.OnTheMove )
        {
            Animator_comp.PlayIdle();
        }
    }



    public void PerformWork()
    {
        if (Ocupied && SubscribedProducer != null)
        {
            switch (SubscribedProducer.work)
            {
                case WorkType.Mining:
                    Animator_comp.PlayClip(Animator_comp.clips[1]);
                    if (!progressPoint) StartCoroutine(workTime(UnitProfile.MiningSpeed.StatValue - UnitProfile.MiningSpeed.BonusValue));
                    break;
                case WorkType.Harvest:
                    Animator_comp.PlayClip(Animator_comp.clips[2]);
                    if (!progressPoint) StartCoroutine(workTime(UnitProfile.MiningSpeed.StatValue - UnitProfile.MiningSpeed.BonusValue));
                    break;
                default:
                    break;
            }
        }
    }

    public void SubscribeToProducer(Core_ResourceProducer producer) 
    {
        SubscribedProducer = producer;

        bool Included = false;

        for (int i = 0; i < producer.UnitsOnWork.Count; i++)
        {
            if (producer.UnitsOnWork[i] == this)
            {
                Included = true;
            }
        }

        if (Included == false) producer.UnitsOnWork.Add(this);
        

    }

    public void UnSubscribeFromProducer(Core_ResourceProducer producer)
    {
        producer.UnitsOnWork.Remove(this);
        SubscribedProducer = null;
    }

    public void checkProducer() 
    {
        if (SubscribedProducer != null)
        {
            float producerDistance = Vector3.Distance(transform.position, SubscribedProducer.transform.position);
            if (producerDistance > pathfinder_comp.move_Comp.arrivalDistance && Ocupied)
            {
                Ocupied = false;
                progressPoint = false;
                UnSubscribeFromProducer(SubscribedProducer);
            }

            if (producerDistance <= pathfinder_comp.move_Comp.arrivalDistance && !Ocupied)
            {
                Ocupied = true;
            }
        }

    
    }

    public IEnumerator workTime(float time) 
    {
        progressPoint = true;
        yield return new WaitForSeconds(time);
        Debug.Log("DINGDONG PROGRESS");
        if (SubscribedProducer != null) SubscribedProducer.resourceProducerProfile.Progress.StatValue += UnitProfile.Workforce.StatValue;

        progressPoint = false;
    }

}
