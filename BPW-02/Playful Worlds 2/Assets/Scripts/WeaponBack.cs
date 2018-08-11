using System.Collections;
using UnityEngine;

public class WeaponBack : MonoBehaviour
{

    public Transform Spawnpoint;
    public GameObject Prefab;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
