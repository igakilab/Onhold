using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class ballCreateScript : MonoBehaviour
{

    public GameObject cubePrefab;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Random.Range(0, 60) >= 58)
        {
            // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
            GameObject cube = Instantiate(cubePrefab) as GameObject;
            // ランダムな場所に配置する
            cube.transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), Random.Range(20, 24));

        }

    }
}
