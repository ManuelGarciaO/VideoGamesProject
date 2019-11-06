using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMovementT : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 velocity;

    public bool moveTriangle;

    [Range(1, 10)]
    public float jumpVelocity;
    private bool grounded;

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
            
        }
        if (Input.GetKey("m"))
        {
            moveTriangle = false;
        }

        if ((Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow)) && grounded == true && moveTriangle)
        {
            Jump();
        }


    }
    public void freezeTriangle()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    private void Jump()
    {
        grounded = false;
        Debug.Log("Salto");
        GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "PlayerTria" || collision.gameObject.tag == "PlayerCube" || collision.gameObject.tag == "PlayerRec")
        {
            grounded = true;
            Debug.Log("Suelo");
            if (!moveTriangle)
            {
                freezeTriangle();
            }
        }
    }

}
