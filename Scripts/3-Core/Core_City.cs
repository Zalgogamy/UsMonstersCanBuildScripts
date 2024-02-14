using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core_City : MonoBehaviour
{
    public Abstract_Town TownProfile;

    public List<Core_Building>Houses = new List<Core_Building>();

    public List<Core_Building> Silos = new List<Core_Building>();


    public void findBasicBuildings() 
    {
        GameObject[] Buildings = GameObject.FindGameObjectsWithTag("Building");
        
        Core_Building currentCore;
        for (int i = 0; i < Buildings.Length; i++)
        {
            currentCore = Buildings[i].GetComponent<Core_Building>();
            if (currentCore.BuildingProfile.Type == BuildingTag.house) 
            {
                Houses.Add(currentCore);
            }
            if (currentCore.BuildingProfile.Type == BuildingTag.silo)
            { 
                Silos.Add(currentCore); 
            }

        }
    }

    public void CalculateHousing() 
    {
        int newHousing = 0;

        for (int i = 0; i < Houses.Count; i++)
        {
            newHousing += Houses[i].BuildingProfile.MainStat.MaxStat;
        }

        TownProfile.InhabitantsCapacity.MaxStat = newHousing;
    }

    public void CalculateFoodCapacity()
    {
        int newCapacity = 0;

        for (int i = 0; i < Silos.Count; i++)
        {
            newCapacity += Silos[i].BuildingProfile.MainStat.MaxStat;
        }

        TownProfile.Food.MaxStat = newCapacity;
    }

    public void CalculateFood()
    {
        float newCapacity = 0;

        for (int i = 0; i < Silos.Count; i++)
        {
            newCapacity += Silos[i].BuildingProfile.MainStat.StatValue;
        }

        TownProfile.Food.StatValue = newCapacity;
    }

    private void Awake()
    {
        findBasicBuildings();
        CalculateHousing();
        CalculateFoodCapacity();
        CalculateFood();
    }

}
