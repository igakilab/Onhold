using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private float collisionTime;
    private Boolean hasCollision = false;
    public Material capMaterial;
    //public GameObject comboText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hasCollision)
        {
            transform.position -= new Vector3(-0.01f, 0f, 1f * Time.deltaTime);
        } else
        {
            transform.position -= new Vector3(0f, 0f, 12f * Time.deltaTime);
        }
        if (transform.position.z <= 0)
        {
            //comboText.GetComponent<TextMesh>().text = 0.ToString();
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
