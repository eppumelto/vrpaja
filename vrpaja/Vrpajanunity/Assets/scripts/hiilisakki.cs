using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiilisakki : MonoBehaviour
{
    public GameObject coal;
    public Transform spawnPos;


    private float timer = 1f;
    public float timerAika = 10f;
    public int limit = 25;


    void Start()
    {
        
    }

    void Spawn ()
    {
        //tee timer mikä spawnaa hiiltä
        if(timer <= 0)
        {
            Instantiate(coal, spawnPos.transform.position, spawnPos.transform.rotation);
            timer = timerAika;
        }
            
    }


    public void Kadessa()
    {
        Debug.Log("Kadessa");
        if (transform.eulerAngles.z >= 80 && transform.eulerAngles.z <= 180 && limit >= 0)
        {
            InvokeRepeating("Spawn", 0, 0);
        }

        timer = timer - Time.deltaTime;
    }
    
    void Update()
    {
        

        //if (transform.eulerAngles.y >= 90 && transform.eulerAngles.y <= 180)
        //{
        //    InvokeRepeating("Spawn", time, delay);
        //}

    }
}
