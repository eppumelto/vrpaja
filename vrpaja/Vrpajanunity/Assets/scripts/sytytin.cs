using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sytytin : MonoBehaviour
{
    public GameObject Liekki;
    public static bool Osuma;

    public void Start()
    {
        Osuma = false;
    }

    public void Update()
    {   
      
        
    }
    public void Shoot ()
    {
        


        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit, Mathf.Infinity)&& hit.transform.tag =="nuotio" &&  fire.isFlameable == true) {

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
            Osuma = true;
           
        }


        Liekki.SetActive(true);
 
    }
    public void NoShoot()
    {
        Liekki.SetActive(false);
      
    }
}
