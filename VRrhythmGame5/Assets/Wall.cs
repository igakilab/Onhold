using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public GameObject comboText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Cube")
        {
            comboText.GetComponent<TextMesh>().text = 0.ToString();
        }
        if(collision.gameObject.tag != "Stick")
        {
            Destroy(collision.gameObject);
        }
    }
}
