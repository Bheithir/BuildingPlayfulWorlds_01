using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beepboop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	
	void Awake () {
        Application.targetFrameRate = 300;
        QualitySettings.vSyncCount = 0;
    }
}
