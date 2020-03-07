using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fig5 : MonoBehaviour
{

    public GameObject centerSphere;
    private Vector3 centerSpherePosition;

    public GameObject magLineOrigin;
    private Vector3 magLineOriginPosition;


    private Vector3 mousePos;
    public GameObject mouseCursor;


    private GameObject lineDrawing;
    private LineRenderer lineRender;


    private GameObject magLineDrawing;
    private LineRenderer magLineRender;

    private float x, y, z;


    private Vector3 subtractedVector;

    private float vectorMagnitude;


    void Start()
    {

        centerSpherePosition = centerSphere.transform.position;
        magLineOriginPosition = magLineOrigin.transform.position;


        mouseCursor = Instantiate(mouseCursor, new Vector3(0, 0, 0), Quaternion.identity);

        // Create a GameObject that will be the line
        lineDrawing = new GameObject();
        magLineDrawing = new GameObject();

        lineRender = lineDrawing.AddComponent<LineRenderer>();
        magLineRender = magLineDrawing.AddComponent<LineRenderer>();

    }

    void Update()
    {

        mousePos = Input.mousePosition;

        centerSpherePosition = centerSphere.transform.position;

        subtractVector(mousePos, centerSpherePosition);

        lineRender.SetPosition(0, centerSpherePosition);
        lineRender.SetPosition(1, subtractedVector);

        mouseCursor.transform.position = new Vector3(x, y, z);


        magLineRender.SetPosition(0, magLineOriginPosition);
        magLineRender.SetPosition(1, new Vector3(vectorMagnitude, vectorMagnitude, vectorMagnitude));

    }

    void subtractVector(Vector3 originalV3, Vector3 v3)
    {


        x = (originalV3.x - v3.x) / 100;
        y = (originalV3.y - v3.y) / 100;
        z = (originalV3.z - v3.z) / 100;

        subtractedVector = new Vector3(x, y, z);


        vectorMagnitude = Vector3.Magnitude(subtractedVector);
    }
}
