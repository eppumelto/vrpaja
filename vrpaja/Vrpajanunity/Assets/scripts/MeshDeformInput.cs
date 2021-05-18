using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshDeformInput : MonoBehaviour
{
    public float force = 10f;
    public float forceOffset = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     

       


    }

    public void  HandleInput()
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
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit, Mathf.Infinity) && hit.transform.tag == "metalli")
        {
            MeshDeformer deformer = hit.collider.GetComponent<MeshDeformer>();

            if (deformer)
            {
                Vector3 point = hit.point;
                point += hit.normal * forceOffset;
                deformer.AddDeformingForce(point, force);
            }

        }
    }

}
