using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVertices : MonoBehaviour {

    public float verticesAngle;
    public List<Vector3> verticesList;
    public bool ifDone;

    //public GameObject test;
	// Use this for initialization
	void Start () {
        verticesList = getTopHalfVertices(GetComponent<MeshFilter>().mesh);
        Debug.Log("total vertices is " + get_total_views());
        ifDone = true;

    }
	
	// Update is called once per frame
	void Update () {
        //test.transform.position = verticesList[(int)(Random.value * verticesList.Count)];
	}

    List<Vector3> getTopHalfVertices(Mesh mesh)
    {
        List<Vector3> list = new List<Vector3>();

        foreach (Vector3 v in mesh.vertices)
        {
            // convert to spherical coordinate and see if it's upward vertices
            float rho, theta,fi;
            rho = Vector3.Magnitude(v);
            theta = Mathf.Rad2Deg * Mathf.Acos(v.z / rho);
            fi = Mathf.Rad2Deg * Mathf.Atan(v.y / v.x);
            if (theta < verticesAngle)
            {
                if (list.Contains(v))
                    continue;
                list.Add(transform.TransformPoint(v));
                //Debug.DrawLine(Vector3.zero, transform.TransformPoint(v), Color.red, 10f);
                //Debug.Log(theta + ", with V = " + v);
            }
        }

        
        return list;
    }


    public Vector3 get_random_vertice()
    {
        Vector3 v = verticesList[(int)(Random.value * verticesList.Count)]; //?????(int)(Random.value * verticesList.Count)????
       
        v.y = 1.4f;
        v.x *= 0.5f;
        v.z *= 0.5f;

        return v;
    }

    public Vector3 get_circle_vertice(Vector3 objPos, int c)
    {
        Vector3 v = verticesList[(int)(Random.value * verticesList.Count)]; //?????(int)(Random.value * verticesList.Count)????

        v.y = objPos.y + 0.5f + Random.value * 0.6f;
        //v.x = totePos.x + 0.2f * Mathf.Cos(c * (Mathf.PI/ (180 / 12)));
        //v.z = totePos.z + 0.2f * Mathf.Sin(c * (Mathf.PI / (180 / 12)));
        v.x = objPos.x + (0.2f + 0.2f* Random.value) * Mathf.Cos(c * (Mathf.PI / (180 / 24)));
        v.z = objPos.z + (0.2f + 0.2f * Random.value) * Mathf.Sin(c * (Mathf.PI / (180 / 24)));

        return v;
    }
    public Vector3 get_look_vertice(Vector3 objPos, int c) ///look at pos
    {
        Vector3 v = verticesList[(int)(Random.value * verticesList.Count)]; 
        v.y = objPos.y - 0.2f + Random.value * 0.1f;
        v.x = objPos.x + Random.value * 0.05f;
        v.z = objPos.z + Random.value * 0.05f;

        return v;
    }

    public int get_total_views()
    {
        return verticesList.Count;
    }

    public Vector3 getVerticeAt(int cnt)
    {
        if (cnt >= verticesList.Count)
            return Vector3.zero;
        return verticesList[cnt];
    }

}
