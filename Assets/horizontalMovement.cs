using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 velocity;
    public float jumpforce;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(velocity);
        /*if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }*/
        if (Input.GetKey("a"))
        { // move to the left
            rb.AddForce(-velocity * Time.deltaTime, ForceMode2D.Impulse);
            //rb.MovePosition(rb.position - velocity * Time.fixedDeltaTime);
            //transform.Translate(-velocity);
        }
        if (Input.GetKey("d"))
        { // move to the right
            rb.AddForce(velocity * Time.deltaTime, ForceMode2D.Impulse);
            //rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
            //transform.Translate(velocity);
        }
    }
}
