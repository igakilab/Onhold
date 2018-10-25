using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStick : MonoBehaviour {

    Boolean b = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x <= 0)
        {
            b = true;
        }
        if (transform.position.x > 3)
        {
            b = false;
        }

            transform.position -= new Vector3(6f * Time.deltaTime * (b ? -1 : 1), 0, 0);
    }
}
