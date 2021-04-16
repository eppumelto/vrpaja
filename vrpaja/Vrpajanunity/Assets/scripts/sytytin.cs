using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sytytin : MonoBehaviour
{
    public GameObject Laatikko;

    public void Shoot ()
    {
        Laatikko.SetActive(true);
    }
}
