﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public LevelManager levelmanager;
    // Start is called before the first frame update
    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayerCube")
        {
            levelmanager.currentCheckpointCube = gameObject;
        }
        if (other.gameObject.tag == "PlayerTria")
        {
            levelmanager.currentCheckpointTria = gameObject;
        }
        if (other.gameObject.tag == "PlayerRec")
        {
            levelmanager.currentCheckpointRec = gameObject;
        }
    }
}
