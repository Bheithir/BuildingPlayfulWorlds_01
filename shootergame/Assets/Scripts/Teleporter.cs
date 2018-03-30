using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public GameObject ui;
    public GameObject objToTp;
    public Transform TpLoc;
    public int code;

	// Use this for initialization
	void Start () {
        ui.SetActive(false);
	}
	
    void OnTriggerStay (Collider other)
    {
        ui.SetActive(true);
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
            objToTp.transform.position = TpLoc.transform.position;
        }
    }
	// Update is called once per frame
	void OnTriggerExit () {
        ui.SetActive(false);
	}
}
