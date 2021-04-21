using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public bool isOnFire;
    public static bool isFlameable;
    public float firetime;
    public GameObject nuotioTrigger;
    public int maara;

    //tarkista montako halkoa on ja pienin määrä on 3
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
         maara = GameObject.FindGameObjectsWithTag("wood").Length;
        if (maara >= 3)
        {
            isFlameable = true;
        }
    }

    void Update()
    {
        
    }
}
