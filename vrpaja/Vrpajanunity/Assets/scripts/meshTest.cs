using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshTest : MonoBehaviour
{
  

    public Material material;

    public bool editable;

    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;
    public GameObject point5;
    public GameObject point6;
    public GameObject point7;
    public GameObject point8;
    // Start is called before the first frame update
    void Start()
    {
        Vector3[] vertices = new Vector3[] {
            //back
            new Vector3 (0,0,0), new Vector3 (1,0,0), new Vector3 (0,1,0), new Vector3 (1,1,0),
            //right
            new Vector3 (1,0,0), new Vector3 (1,0,1), new Vector3 (1,1,0), new Vector3 (1,1,1),
            //front
            new Vector3 (1,0,1), new Vector3 (0,0,1), new Vector3 (1,1,1), new Vector3 (0,1,1),
            //left
            new Vector3 (0,0,1), new Vector3 (0,0,0), new Vector3 (0,1,1), new Vector3 (0,1,0),
            //up
            new Vector3 (0,1,0), new Vector3 (1,1,0), new Vector3 (0,1,1), new Vector3 (1,1,1),
            //down
            new Vector3 (0,0,0), new Vector3 (1,0,0), new Vector3 (0,0,1), new Vector3 (1,0,1),
        };
        Vector2[] uv = new Vector2[] {

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),

           new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),

          new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),

              new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),



        };
        int[] triangles = new int[] {

            0,3,1,
            3,0,2,

            4,7,5,
            7,4,6,

            8,11,9,
            11,8,10,

            12,15,13,
            15,12,14,

            21,22,20,
            22,21,23,
        };

        Vector3[] Normals = new Vector3[]
        {
            Vector3.back,
            Vector3.back,
            Vector3.back,
            Vector3.back,

            Vector3.right,
            Vector3.right,
            Vector3.right,
            Vector3.right,

            Vector3.forward,
            Vector3.forward,
            Vector3.forward,
            Vector3.forward,

            Vector3.left,
            Vector3.left,
            Vector3.left,
            Vector3.left,

            Vector3.up,
            Vector3.up,
            Vector3.up,
            Vector3.up,

            Vector3.down,
            Vector3.down,
            Vector3.down,
            Vector3.down,
        };


        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = material;
        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;
        mesh.normals = Normals;
        mesh.Optimize();

    }

    // Update is called once per frame
    void Update()
    {
        if(editable == true)
        {
            Vector3[] vertices = new Vector3[] {
            //back
           point1.transform.position, point2.transform.position, point3.transform.position, point4.transform.position,
            //right
            point2.transform.position, point6.transform.position, point7.transform.position, point3.transform.position,
            //front
           point5.transform.position, point6.transform.position, point7.transform.position, point8.transform.position,
            //left
            point5.transform.position, point1.transform.position, point4.transform.position, point8.transform.position,
            //up
            point1.transform.position, point5.transform.position, point6.transform.position, point2.transform.position,
            //down
            point1.transform.position, point2.transform.position, point5.transform.position, point6.transform.position,
        };
            Vector2[] uv = new Vector2[] {

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),

           new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),

          new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),

              new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),



        };
            int[] triangles = new int[] {

            2,1,0,
            1,2,3,

            4,7,5,
            7,4,6,

            9,10,8,
            10,9,11,

            12,15,13,
            15,12,14,

            21,22,20,
            22,21,23,
        };

            Vector3[] Normals = new Vector3[]
            {
            Vector3.back,
            Vector3.back,
            Vector3.back,
            Vector3.back,

            Vector3.right,
            Vector3.right,
            Vector3.right,
            Vector3.right,

            Vector3.forward,
            Vector3.forward,
            Vector3.forward,
            Vector3.forward,

            Vector3.left,
            Vector3.left,
            Vector3.left,
            Vector3.left,

            Vector3.up,
            Vector3.up,
            Vector3.up,
            Vector3.up,

            Vector3.down,
            Vector3.down,
            Vector3.down,
            Vector3.down,
            };


            Mesh mesh = new Mesh();
            GetComponent<MeshFilter>().mesh = mesh;
            GetComponent<MeshRenderer>().material = material;
            mesh.vertices = vertices;
            mesh.uv = uv;
            mesh.triangles = triangles;
            mesh.normals = Normals;
            mesh.Optimize();
        }
        
    }
}
