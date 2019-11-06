using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;
    private bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow)) && grounded == true)
        {
            Jump();
        }
    }
    private void Jump()
    {
        grounded = false;
        Debug.Log("Salto");
        GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag== "PlayerTria" || collision.gameObject.tag == "PlayerCube" || collision.gameObject.tag == "PlayerRec")
        {
            grounded = true;
            Debug.Log("Suelo");
        }
    }
}
