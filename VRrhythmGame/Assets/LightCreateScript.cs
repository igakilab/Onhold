using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCreateScript : MonoBehaviour {

    public GameObject lightPrefab;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Random.Range(0, 100) >= 50)
        {
            GameObject light = Instantiate(lightPrefab) as GameObject;
            light.transform.position = new Vector3(Random.Range(3, 8), Random.Range(-1, 3), 30);
            GameObject light2 = Instantiate(lightPrefab) as GameObject;
            light2.transform.position = new Vector3(Random.Range(-3, -8), Random.Range(-1, 3), 30);
            GameObject light3 = Instantiate(lightPrefab) as GameObject;
            light3.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(4, 6), 30);
            GameObject light4 = Instantiate(lightPrefab) as GameObject;
            light4.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-2, -4), 30);

        }
    }
}
