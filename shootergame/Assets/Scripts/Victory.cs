using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour {

    public GameObject ui;

    // Use this for initialization
    void Start () {
        ui.SetActive(false);
	}

    void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);
        if ((other.gameObject.tag == "Player"))
        {
            ui.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
