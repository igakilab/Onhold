﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DispCombo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.HasKey("combo"))
        {
            this.gameObject.GetComponent<Text>().text = PlayerPrefs.GetString("combo");
        }
        
	}
}
