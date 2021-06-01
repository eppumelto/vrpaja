using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshDeformInput : MonoBehaviour
{
    public float force = 10f;
    public float forceOffset = 0.1f;

    public GameObject rayCastHitPointJuttu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     

       


    }

    //public void OnCollisionEnter(Collision other)
    //{
    //    ContactPoint hit;

    //    MeshDeformer deformer = .GetComponent<MeshDeformer>();

    //    Debug.DrawRay(transform.position, transform.forward, Color.green);

    //    if (deformer)
    //    {
    //        Vector3 point = hit.point;
    //        point += hit.normal * forceOffset;
    //        deformer.AddDeformingForce(point, force);
    //    }
    //}


    public void HandleInput()
    {
        RaycastHit hit;

        //if (Physics.Raycast(inputRay, out hit))
        //{
        //    MeshDeformer deformer = hit.collider.GetComponent<MeshDeformer>();

        //    if (deformer)
        //    {
        //        Vector3 point = hit.point;
        //        point += hit.normal * forceOffset;
        //        deformer.AddDeformingForce(point, force);
        //    }
        //}
        if (Physics.Raycast(rayCastHitPointJuttu.transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            MeshDeformer deformer = hit.collider.GetComponent<MeshDeformer>();

            Debug.DrawRay(rayCastHitPointJuttu.transform.position, transform.forward, Color.green);

            if (deformer)
            {
                Vector3 point = hit.point;
                point += hit.normal * forceOffset;
                deformer.AddDeformingForce(point, force);
            }

        }
    }

}
