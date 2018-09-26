using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(0f, 0f, 6f * Time.deltaTime);
        if (transform.position.z <= -4)
        {
            Destroy(transform.gameObject);
        }
    }
}
