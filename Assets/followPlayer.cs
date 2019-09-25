using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        transform.position = someFun(player.position) + offset;
    }
    Vector3 someFun(Vector2 v)
    {

        return new Vector3(v.x, v.y, 0.0f);
    }
}
