using System.Collections;
using UnityEngine;

public class spawner : MonoBehaviour {

    public Transform Spawnpoint;
    public GameObject Prefab;

    // Use this for initialization
	void OnTriggerEnter () {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
