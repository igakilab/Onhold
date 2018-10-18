using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public Material capMaterial;
    public GameObject explode;//explodeにはunity上でprefabを関連付けます

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnCollisionEnter(Collision collision)
    {
        //GameObject.Destroy(collision.gameObject);

        // Debug.Log(collision.contacts[0].point);
        
        GameObject victim = collision.gameObject;
        victim.GetComponent<Rigidbody>().useGravity = true;

        GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.forward, capMaterial);
        // GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.right, transform.position, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
            pieces[1].AddComponent<Rigidbody>();

        Destroy(pieces[1], 1);
        

        //this.transform.localScale = Vector3.zero; //みえない大きさにする
        // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
        // Instantiate(explode, this.transform.position, Quaternion.identity);
        //ぶつかった位置にexplodeというprefabを配置する


        // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
        //GameObject explosion = Instantiate(explode) as GameObject;
        //explosion.transform.position = this.transform.position;
    }
    /*
    private collect (GameObject gameObject, Vector3 position, Vector3 right)
    {

    }*/
}
