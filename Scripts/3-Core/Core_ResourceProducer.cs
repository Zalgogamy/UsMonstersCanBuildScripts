using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Core_ResourceProducer : Basic_SelectableCore
{
    public Abstract_ResourceProducer resourceProducerProfile;
    public WorkType work;
    public Canvas Canvas;
    public Image FillImage;
    public List<Core_PlayeableUnit> UnitsOnWork = new List<Core_PlayeableUnit>();

    public void Awake()
    {
        Canvas.worldCamera = Camera.main;
    }

    private void Update()
    {
        if (resourceProducerProfile.Progress.StatValue >= resourceProducerProfile.Progress.MaxStat)
        {
            resetWork();
        }
        Checkprogress();
    }


    public void resetWork() 
    {
        resourceProducerProfile.Progress.StatValue = 0;
        GiveReward();
    }

    public void Checkprogress() 
    {
        if (UnitsOnWork.Count != 0)
        {
            if (!Canvas.gameObject.active)
            {
                Canvas.gameObject.SetActive(true);
            }

            FillImage.fillAmount = resourceProducerProfile.Progress.StatValue / 10;
        }
        else
        {
            Canvas.gameObject.SetActive(false);
        }
       
    }

    public void GiveReward() 
    {
        float Capacity = 0;

        for (int i = 0; i < UnitsOnWork.Count; i++)
        {
            Capacity = UnitsOnWork[i].UnitProfile.InventorySize.StatValue + UnitsOnWork[i].UnitProfile.InventorySize.BonusValue;

            if (UnitsOnWork[i].WorkInventory.Count < Capacity)
            {
                UnitsOnWork[i].WorkInventory.Add(randomItem());

                if (UnitsOnWork[i].WorkInventory.Count == Capacity)
                {
                    UnitsOnWork[i].UnSubscribeFromProducer(this);
                }
            }
        }
    }

    public Template_resource randomItem() 
    {
        Template_resource ItemToReturn;
        int selected = Random.Range(0, resourceProducerProfile.ItemPool.Length-1);
        ItemToReturn = resourceProducerProfile.ItemPool[selected];
        return ItemToReturn;
    }

}
