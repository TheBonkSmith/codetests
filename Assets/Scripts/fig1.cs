using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter1Fig1 : MonoBehaviour
{

    private float xspeed = .03F;
    private float yspeed = .03F;
    private float zspeed = .03F;

    private float xMin = -10, xMax = 10, yMin = -10, yMax = 10, zMin = -10, zMax = 10;
    public bool xHit, yHit, zHit = true;

    public GameObject mover;
    private float x;
    private float y;
    private float z;

    void Start()
    {
        mover = Instantiate(mover, new Vector3(0, 0, 0), Quaternion.identity);

    }

    void Update()
    {

        x = mover.transform.position.x;
        y = mover.transform.position.y;
        z = mover.transform.position.z;

        if (xHit)
        {
            mover.transform.position += new Vector3(xspeed, 0, 0);
            if (x > xMax)
            {
                xHit = false;
            }
        }
        else
        {
            mover.transform.position -= new Vector3(xspeed, 0, 0);
            if (x < xMin)
            {
                xHit = true;
            }
        }
        if (yHit)
        {
            mover.transform.position += new Vector3(0, yspeed, 0);
            if (y > yMax)
            {
                yHit = false;
            }
        }
        else
        {
            mover.transform.position -= new Vector3(0, yspeed, 0);
            if (y < yMin)
            {
                yHit = true;
            }
        }
        if (zHit)
        {
            mover.transform.position += new Vector3(0, 0, zspeed);
            if (z > zMax)
            {
                zHit = false;
            }
        }
        else
        {
            mover.transform.position -= new Vector3(0, 0, zspeed);
            if (z < zMin)
            {
                zHit = true;
            }
        }
    }
}


