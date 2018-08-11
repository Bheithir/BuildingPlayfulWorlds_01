using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public AudioSource sound;
    public GameObject objToDestroy;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            sound = gameObject.GetComponent<AudioSource>();
            sound.Play();
            Destroy(objToDestroy);
            Score.scoreValue += 1;
        }

    }
}