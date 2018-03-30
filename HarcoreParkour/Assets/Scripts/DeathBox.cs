using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{

    
    public GameObject objToTp;
    public Transform TpLoc;
    public int code;

    // Use this for initialization
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {

            objToTp.transform.position = TpLoc.transform.position;

        }
    }
    // Update is called once per frame
    
}
