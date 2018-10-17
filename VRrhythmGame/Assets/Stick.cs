using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public Material capMaterial;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnCollisionEnter(Collision collision)
    {
        //GameObject.Destroy(collision.gameObject);
        GameObject victim = collision.gameObject;

        GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.forward, capMaterial);
        // GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.right, transform.position, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
            pieces[1].AddComponent<Rigidbody>();

        Destroy(pieces[1], 1);
    }
    /*
    private collect (GameObject gameObject, Vector3 position, Vector3 right)
    {

    }*/
}
