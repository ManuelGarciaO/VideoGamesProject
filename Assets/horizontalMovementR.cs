using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMovementR : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 velocity;
    public float jumpforce;

    public bool moveRec;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveRec = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (moveRec)
        {
            float h = Input.GetAxis("Horizontal");
            print(h);
            float v = Input.GetAxis("Vertical");


            transform.Translate(
                h * Time.deltaTime * velocity,
                Space.World
                );

        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }

        if (Input.GetKey("m"))
        {
            moveRec = true;
            rb.constraints = RigidbodyConstraints2D.None;
        }
        if (Input.GetKey("b"))
        {
            moveRec = false;
            freezeRec();
        }
        if (Input.GetKey("n"))
        {
            moveRec = false;
            freezeRec();
        }


    }
    public void freezeRec()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

}
