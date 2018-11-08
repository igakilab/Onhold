using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position -= new Vector3(0f, 0f, 15f * Time.deltaTime);

        if (transform.position.z <= 0)
        {
            Destroy(transform.gameObject);
        }
    }
}
