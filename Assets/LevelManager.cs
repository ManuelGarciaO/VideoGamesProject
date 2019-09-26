using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;
    private horizontalMovement player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<horizontalMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void respawnPlayer()
    {
        Debug.Log("Player Respawn here");
        player.transform.position = currentCheckpoint.transform.position;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}
