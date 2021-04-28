using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public bool isOnFire;
    public static bool isFlameable;

    public float firetime = 0f;
    public float heat = 0f;

    public GameObject nuotioTrigger;
    public GameObject Tuli;
    public int maara = 0;


    //tarkista montako halkoa on ja pienin määrä on 3
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wood")
        {

            maara += 1;
            firetime += 3.0f;

            if (firetime == 0f)
            {
                Destroy(other);
            }
        }

        if (other.tag == "coal")
        {
            firetime += 5f;
            //do things
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
        if(other.CompareTag("wood") && firetime == 0)
        {
            Destroy(other.gameObject);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "wood")
        {

            maara -= 1;
            
        }
    }

    private void FireTime()
    {
        firetime -= Time.deltaTime;
        heat += Time.deltaTime;
    }


    void Update()
    {
        

        if (maara >= 3)
        {
            isFlameable = true;
        }

        else
        {
            isFlameable = false;
            sytytin.Osuma = false;
        }
        if (sytytin.Osuma == true)
        {
            Tuli.SetActive(true);
            FireTime();
            if (firetime <= 0f)
            {
               
                sytytin.Osuma = false;
                firetime = 0;

                

            }
        }
        else
        {
            Tuli.SetActive(false);
        }

       
    }
}
