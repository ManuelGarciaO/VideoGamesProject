using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMovementR : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 velocity;
    public bool moveRec;

    [Range(1, 10)]
    public float jumpVelocity;
    private bool grounded;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveRec = false;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            Quaternion target = Quaternion.Euler(0, 0, 90);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 5);
        }

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

        if (Input.GetKey("m"))
        {
            moveRec = true;
            rb.constraints = RigidbodyConstraints2D.None;
        }
        if (Input.GetKey("b"))
        {
            moveRec = false;
        }
        if (Input.GetKey("n"))
        {
            moveRec = false;
        }

        if ((Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow)) && grounded == true && moveRec)
        {
            Jump();
        }


    }
    public void freezeRec()
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
            if (!moveRec)
            {
                freezeRec();
            }
        }
    }

}
