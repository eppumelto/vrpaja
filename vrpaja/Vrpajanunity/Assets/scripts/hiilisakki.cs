using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiilisakki : MonoBehaviour
{
    public GameObject coal;
    public Transform spawnPos;

    public float time;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Spawn ()
    {
        Instantiate(coal, transform.position, transform.rotation);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.y >= 90 && transform.eulerAngles.y <= 180)
        {
            InvokeRepeating("Spawn", time, delay);
        }
    }
}
