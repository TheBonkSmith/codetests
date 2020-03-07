using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class fig3 : MonoBehaviour
{


    public GameObject centerSphere;
    private Vector3 centerSpherePosition;


    private Vector3 mousePos;
    public GameObject mouseCursor;

    private GameObject lineDrawing;
    private LineRenderer lineRender;

    private float x, y, z;

    private Vector3 subtractedVector;

    void Start()
    {

        centerSpherePosition = centerSphere.transform.position;


        mouseCursor = Instantiate(mouseCursor, new Vector3(0, 0, 0), Quaternion.identity);

    
        lineDrawing = new GameObject();

        lineRender = lineDrawing.AddComponent<LineRenderer>();

    }

    void Update()
    {

        mousePos = Input.mousePosition;


        centerSpherePosition = centerSphere.transform.position;

        
        subtractVector(mousePos, centerSpherePosition);


        lineRender.SetPosition(0, centerSpherePosition);
        lineRender.SetPosition(1, new Vector3(x, y, z));

 
        mouseCursor.transform.position = subtractedVector;

    }

    void subtractVector(Vector3 originalV3, Vector3 v)
    {

        x = (originalV3.x - v.x) / 100;
        y = (originalV3.y - v.y) / 100;
        z = (originalV3.z - v.z) / 100;

        subtractedVector = new Vector3(x, y, z);
    }

}


