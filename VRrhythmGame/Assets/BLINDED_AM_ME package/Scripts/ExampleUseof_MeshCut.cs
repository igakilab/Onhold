using UnityEngine;
using System.Collections;

public class ExampleUseof_MeshCut : MonoBehaviour {

	public Material capMaterial;

	// Use this for initialization
	void Start () {

		
	}

    private void OnCollisionEnter(Collision collision)
    {
        
        GameObject victim = collision.gameObject;

        GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
            pieces[1].AddComponent<Rigidbody>();

        Destroy(pieces[1], 1);
        
        /*
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {

            GameObject victim = hit.collider.gameObject;

            GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

            if (!pieces[1].GetComponent<Rigidbody>())
                pieces[1].AddComponent<Rigidbody>();

            Destroy(pieces[1], 1);
        }*/
    }

    void Update()
    {


        /*
    RaycastHit hit;

    if (Physics.Raycast(transform.position, transform.forward, out hit))
    {
        GameObject victim = hit.collider.gameObject;

        if (victim.tag != "Cylinder")
        {
            GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

            if (!pieces[1].GetComponent<Rigidbody>())
                pieces[1].AddComponent<Rigidbody>();

            Destroy(pieces[1], 1);

        }

    }
    /*
    if(){
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit)){

            GameObject victim = hit.collider.gameObject;

            GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

            if(!pieces[1].GetComponent<Rigidbody>())
                pieces[1].AddComponent<Rigidbody>();

            Destroy(pieces[1], 1);
        }

    }*/
    }

    void OnDrawGizmosSelected() {

		Gizmos.color = Color.green;

		Gizmos.DrawLine(transform.position, transform.position + transform.forward * 0.2f);
		Gizmos.DrawLine(transform.position + transform.up * 1.5f, transform.position + transform.up * 1.5f + transform.forward * 0.2f);
		Gizmos.DrawLine(transform.position + -transform.up * 1.5f, transform.position + -transform.up * 1.5f + transform.forward * 0.2f);

		Gizmos.DrawLine(transform.position, transform.position + transform.up * 1f);
		Gizmos.DrawLine(transform.position,  transform.position + -transform.up * 1f);

	}

}
