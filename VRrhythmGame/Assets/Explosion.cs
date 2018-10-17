using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explode;//explodeにはunity上でprefabを関連付けます

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update () {

    }
    void OnCollisionEnter(Collision collision) //衝突時の処理
    {
        //Destroy(this.gameObject);
        if (collision.gameObject.tag == "Stick")
        //タグで限定（他のオブジェクトに衝突した場合は呼び出さない
        {
            this.transform.localScale = Vector3.zero; //みえない大きさにする
            Instantiate(explode, this.transform.position, Quaternion.identity);
            //ぶつかった位置にexplodeというprefabを配置する
        }
    }
}
