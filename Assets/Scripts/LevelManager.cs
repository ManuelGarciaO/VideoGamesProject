using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private horizontalMovement cube;
    private horizontalMovementT tria;
    private horizontalMovementR rec;
    public GameObject currentCheckpointCube;
    public GameObject currentCheckpointTria;
    public GameObject currentCheckpointRec;
    
    // Start is called before the first frame update
    void Start()
    {
        cube = FindObjectOfType<horizontalMovement>();
        tria = FindObjectOfType<horizontalMovementT>();
        rec = FindObjectOfType<horizontalMovementR>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void respawnPlayerCube()
    {
        Debug.Log("Player Respawn here");
        cube.transform.position = currentCheckpointCube.transform.position;
        cube.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
    public void respawnPlayerTria()
    {
        Debug.Log("Player Respawn here");
        tria.transform.position = currentCheckpointTria.transform.position;
        tria.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
    public void respawnPlayerRec()
    {
        Debug.Log("Player Respawn here");
        rec.transform.position = currentCheckpointRec.transform.position;
        rec.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}
