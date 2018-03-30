using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float speed = 5.0F;

    bool onGround = true;
    // Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}

    // Update is called once per frame
    void Update() {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

        RaycastHit hit;
        Vector3 physicsCentre = this.transform.position + this.GetComponent<CapsuleCollider>().center;

        Debug.DrawRay(physicsCentre, Vector3.down * 0.4f, Color.red, 1);
        if (Physics.Raycast(physicsCentre, Vector3.down, out hit, 0.4f))
        {
            if (hit.transform.gameObject.tag != "Player")
            {
                onGround = true;
            }
        }
        else
        {
            onGround = false;
        }
        Debug.Log(onGround);

        if (Input.GetKeyDown("space") && onGround)
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
	}
}
