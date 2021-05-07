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

   

    //Otin boolin mikä katsoo onko object valittu ja jos on niin silloin hiilisakista voi tippua hiilia
    //Myös timer minkä mukaan se tiputtaa hiilia ettei ne pursua liian nopeasti
    void Spawn ()
    {
        if (timer <= 0 && GetComponent<XRGrabInteractable>().isSelected)
        {
            Instantiate(coal, spawnPos.transform.position, spawnPos.transform.rotation);
            timer = timerAika;
        }
            
    }


    
    void Update()
    {
        //reference = GameObject.Find("Hiilisakki").GetComponent<XRGrabInteractable>().isSelected;

        if (transform.eulerAngles.z >= 80 && transform.eulerAngles.z <= 180 && limit >= 0)
        {
            InvokeRepeating("Spawn", 0, 0);
        }

        timer = timer - Time.deltaTime;

  

    }
}
