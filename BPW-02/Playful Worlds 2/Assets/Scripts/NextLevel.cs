using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    public GameObject UIObject;
    public string LevelToLoad;

	// Use this for initialization
	void Start () {
        UIObject.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
		if(other.gameObject.tag == "player")
        {
            UIObject.SetActive(true);
            if(UIObject.activeInHierarchy == true && Input.GetButtonDown("Use"))
            {
                Application.LoadLevel(LevelToLoad);
            }
        }
	}
    private void OnTriggerExit(Collider other)
    {
        UIObject.SetActive(false);
    }
}
