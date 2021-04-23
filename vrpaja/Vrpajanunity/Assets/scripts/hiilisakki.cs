using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiilisakki : MonoBehaviour
{
    public GameObject coal;
    public Transform spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Spawn ()
    {
        Instantiate(coal, spawnPos);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
