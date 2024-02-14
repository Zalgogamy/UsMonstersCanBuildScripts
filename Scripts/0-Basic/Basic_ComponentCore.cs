using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_ComponentCore : MonoBehaviour
{
    public Unique_Comunicator Comunicator;
    private void Awake()
    {
        Comunicator = GameObject.Find("Handler").GetComponent<Unique_Comunicator>();
    }
}
