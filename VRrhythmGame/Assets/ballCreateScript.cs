using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class ballCreateScript : MonoBehaviour
{

    public GameObject cubePrefab;
    public float timeOut = 0.1f;
    private float timeElapsed;

    int count = 0;
    /**
     * key: 0.1秒単位
     * value: 方向
     * 同時間に複数のものを配置することはできないので注意
     */
    Dictionary<int, Position> musicfile = new Dictionary<int, Position>()
    {
        {0, Position.CENTER},
        {2, Position.TOP_LEFT},
        {5, Position.TOP},
        {8, Position.TOP_RIGHT},
        {11, Position.LEFT},
        {14, Position.CENTER},
        {17, Position.RIGHT},
        {20, Position.BOTTOM_LEFT},
        {23, Position.BOTTOM},
        {26, Position.BOTTOM_RIGHT},
        {35, Position.CENTER},
        {50, Position.CENTER},
        {65, Position.CENTER},
        {80, Position.CENTER},
        {95, Position.CENTER},
        {110, Position.CENTER},
        {125, Position.CENTER},
        {150, Position.CENTER},
        {175, Position.CENTER},
        {200, Position.CENTER},
        {225, Position.CENTER},
        {250, Position.CENTER},
        {275, Position.CENTER},
        {300, Position.CENTER},
        {325, Position.CENTER},
    };

    enum Position
    {
        TOP_LEFT,
        TOP,
        TOP_RIGHT,
        LEFT,
        CENTER,
        RIGHT,
        BOTTOM_LEFT,
        BOTTOM,
        BOTTOM_RIGHT
    }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update ()
    {

        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            if (Random.Range(0, 60) >= 56)
            {
                GameObject cube1 = Instantiate(cubePrefab) as GameObject;
                cube1.transform.position = new Vector3(Random.Range(-1.25f, 1.25f), Random.Range(0, 2), 20);

            }

            // Do anything
            if (musicfile.ContainsKey(count))
            {
                // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
                GameObject cube = Instantiate(cubePrefab) as GameObject;
                switch (musicfile[count])
                {
                    case Position.TOP_LEFT:
                        cube.transform.position = new Vector3(-1.25f, 2, 20);
                        break;
                    case Position.TOP:
                        cube.transform.position = new Vector3(0, 2, 20);
                        break;
                    case Position.TOP_RIGHT:
                        cube.transform.position = new Vector3(1.25f, 2, 20);
                        break;
                    case Position.LEFT:
                        cube.transform.position = new Vector3(-1.25f, 0, 20);
                        break;
                    case Position.CENTER:
                        cube.transform.position = new Vector3(0, 0, 20);
                        break;
                    case Position.RIGHT:
                        cube.transform.position = new Vector3(1.25f, 0, 20);
                        break;
                    case Position.BOTTOM_LEFT:
                        cube.transform.position = new Vector3(-1.25f, -1, 20);
                        break;
                    case Position.BOTTOM:
                        cube.transform.position = new Vector3(0, -1, 20);
                        break;
                    case Position.BOTTOM_RIGHT:
                        cube.transform.position = new Vector3(1.25f, -1, 20);
                        break;

                }
            }
            count++;
            timeElapsed = 0.0f;
        }
    }

    private void FixedUpdate()
    {
    }
}
