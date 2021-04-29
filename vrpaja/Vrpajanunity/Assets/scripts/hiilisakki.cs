using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class hiilisakki : MonoBehaviour
{
    public GameObject coal;
    public Transform spawnPos;


    private float timer = 1f;
    public float timerAika = 10f;
    public int limit = 25;
    //jos ei toimi voi poistaa
    private bool reference;

    void Start()
    {
        //jos ei toimi voi poistaa
        reference = GameObject.Find("Hiilisakki").GetComponent<XRGrabInteractable>().trackPosition;
        
    }


    //Eli kun se trackaa sen positiota LUULEN että se on kädessä ja silloin kaikki toimii
    void Spawn ()
    {
        //tee timer mikä spawnaa hiiltä
        if (timer <= 0 && reference == true)
        {
            Instantiate(coal, spawnPos.transform.position, spawnPos.transform.rotation);
            timer = timerAika;
        }
            
    }


    
    void Update()
    {

        if (transform.eulerAngles.z >= 80 && transform.eulerAngles.z <= 180 && limit >= 0)
        {
            InvokeRepeating("Spawn", 0, 0);
        }

        timer = timer - Time.deltaTime;

  

    }
}
