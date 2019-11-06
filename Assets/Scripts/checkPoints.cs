using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoints : MonoBehaviour
{
    public Vector3 check1;
    public Vector3 check2;
    public int contador;

    private void Awake()
    {
        if(PlayerPrefs.GetInt("CheckPoints") == 1)
        {
            this.transform.position = check1;
        }

        if (PlayerPrefs.GetInt("CheckPoints") == 2)
        {
            this.transform.position = check2;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "check1")
        {
            contador = 1;
            PlayerPrefs.SetInt("Checkpoints", 1);
        }
        if(other.gameObject.tag == "check2")
        {
            contador = 2;
            PlayerPrefs.SetInt("Checkpoints", 2);
        }
    }
}
