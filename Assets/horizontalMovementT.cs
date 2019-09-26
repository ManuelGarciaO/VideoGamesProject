using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMovementT : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 velocity;
    public float jumpforce;
    public horizontalMovement cube;

    public bool moveTriangle;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveTriangle = false;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;

    }

    // Update is called once per frame
    void Update()
    {
  
        if (moveTriangle)
        {
            float h = Input.GetAxis("Horizontal");
            print(h);
            float v = Input.GetAxis("Vertical");


            transform.Translate(
                h * Time.deltaTime * velocity,
                Space.World
                );
         
        }
        if (Input.GetKey("n"))
        {
            moveTriangle = true;
            rb.constraints = RigidbodyConstraints2D.None;
        }
        if (Input.GetKey("b"))
        {
            moveTriangle = false;
            freezeTriangle();
        }
        if (Input.GetKey("m"))
        {
            moveTriangle = false;
            freezeTriangle();
        }


    }
    public void freezeTriangle()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

}
