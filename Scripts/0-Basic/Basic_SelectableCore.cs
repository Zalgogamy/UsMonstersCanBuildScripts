using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_SelectableCore : MonoBehaviour
{
    public GameObject VisualSelected;
    public Unique_Comunicator Comunicator;
    public Comunicatorstate Status;
    public bool isSelected;

    private void Awake()
    {
        Comunicator = GameObject.Find("Handler").GetComponent<Unique_Comunicator>();
    }

    public void SelectedStatus() 
    {   
        if (isSelected)
        {
            VisualSelected.SetActive(true);
        }
        else
        {
            VisualSelected.SetActive(false);
        }
    }
}
