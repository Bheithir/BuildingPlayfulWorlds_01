using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour {

    public GameObject spawned;
    public float spawnTime;
    public float spawnDelay;

	void Start () {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
	}
	
	// Update is called once per frame
	void SpawnObject () {
        Instantiate(spawned, transform.position, transform.rotation);
        
	}
}
