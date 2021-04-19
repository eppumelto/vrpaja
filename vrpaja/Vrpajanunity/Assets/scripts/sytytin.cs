using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sytytin : MonoBehaviour
{
    public GameObject Liekki;

    public void Shoot ()
    {
        Liekki.SetActive(true);
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
    }
    public void NoShoot()
    {
        Liekki.SetActive(false);
    }
}
