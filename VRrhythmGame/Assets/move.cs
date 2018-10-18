using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private float collisionTime;
    private Boolean hasCollision = false;
    public Material capMaterial;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hasCollision)
        {
            // transform.position -= new Vector3(0f, 6f * (this.collisionTime - Time.deltaTime), 6f * Time.deltaTime);
        } else
        {
            transform.position -= new Vector3(0f, 0f, 6f * Time.deltaTime);
        }
        if (transform.position.z <= -4)
        {
            Destroy(transform.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Stick")
        {
            // transform.gameObject.AddComponent<Rigidbody>();
            this.collisionTime = Time.deltaTime;
            hasCollision = true;


        }
    }
}
