using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiilisakki : MonoBehaviour
{
    public GameObject coal;
    public Transform spawnPos;
    

    public float time;
    public float delay;
    public int limit = 25;


    void Start()
    {
        
    }

    void Spawn ()
    {
        limit = limit - 1;
        Instantiate(coal, spawnPos.transform.position, spawnPos.transform.rotation);

        
    }

    
    void Update()
    {
        if (transform.eulerAngles.z >= 80 && transform.eulerAngles.z <= 180 && limit >= 0)
        {
            InvokeRepeating("Spawn", time, delay);
        }



        //if (transform.eulerAngles.y >= 90 && transform.eulerAngles.y <= 180)
        //{
        //    InvokeRepeating("Spawn", time, delay);
        //}

    }
}
