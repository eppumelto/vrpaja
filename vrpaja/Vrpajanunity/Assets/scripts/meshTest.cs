using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshTest : MonoBehaviour
{
  

    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        Vector3[] newVerticies = new Vector3[4];
        Vector2[] newUV = new Vector2[4];
        int[] newTriangles = new int[6];

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = material;
        mesh.vertices = newVerticies;
        mesh.uv = newUV;
        mesh.triangles = newTriangles;

    }

    // Update is called once per frame
    void Update()
    {

        //Mesh mesh = GetComponent<MeshFilter>().mesh;
        //Vector3[] vertices = mesh.vertices;
        //Vector3[] normals = mesh.normals;
        
        //for (var i = 0; i < vertices.Length; i++)
        //{
        //    vertices[i] += normals[i] * Mathf.Sin(Time.time);
        //}

        //mesh.vertices = vertices;
    }
}
