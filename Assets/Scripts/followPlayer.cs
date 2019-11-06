using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform cube;
    public Transform tria;
    public Transform rec;
    private bool focusCube;
    private bool focusTria;
    private bool focusRec;


    public Vector3 offset;
    private void Start()
    {
        focusCube = true;
        focusTria = false;
        focusRec = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (focusCube)
        {
            transform.position = convertVector(cube.position) + offset;
        }
        if (focusTria)
        {
            transform.position = convertVector(tria.position) + offset;
        }
        if (focusRec)
        {
            transform.position = convertVector(rec.position) + offset;
        }
        if (Input.GetKey("b"))
        {
            focusCube = true;
            focusTria = false;
            focusRec = false;
        }
        if (Input.GetKey("n"))
        {
            focusCube = false;
            focusTria = true;
            focusRec = false;
        }
        if (Input.GetKey("m"))
        {
            focusCube = false;
            focusTria = false;
            focusRec = true;
        }
    }
    Vector3 convertVector(Vector2 v)
    {

        return new Vector3(v.x, v.y, 0.0f);
    }
}
