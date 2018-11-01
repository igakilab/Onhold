using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        {25, Position.CENTER},
        {58, Position.CENTER},
        {91, Position.CENTER},

        {125, Position.TOP_RIGHT},
        {130, Position.TOP},
        {135, Position.TOP_LEFT},
        {157, Position.LEFT},
        {162, Position.CENTER},
        {167, Position.RIGHT},
        {190, Position.BOTTOM_RIGHT},
        {195, Position.BOTTOM},
        {200, Position.BOTTOM_LEFT},
        {224, Position.BOTTOM_LEFT},
        {229, Position.BOTTOM},
        {234, Position.BOTTOM_RIGHT},
        {258, Position.RIGHT},
        {263, Position.CENTER},
        {268, Position.LEFT},
        {290, Position.TOP_LEFT},
        {295, Position.TOP},
        {300, Position.TOP_RIGHT},
        {324, Position.TOP_RIGHT},
        {329, Position.CENTER},
        {334, Position.BOTTOM_LEFT},
        {357, Position.TOP_LEFT},
        {362, Position.CENTER},
        {367, Position.BOTTOM_RIGHT},

        {392, Position.TOP_RIGHT},
        {397, Position.TOP},
        {408, Position.CENTER},
        {413, Position.RIGHT},
        {425, Position.BOTTOM_RIGHT},
        {430, Position.BOTTOM},
        {441, Position.BOTTOM_LEFT},
        {446, Position.BOTTOM},
        {458, Position.CENTER},
        {463, Position.LEFT},
        {474, Position.TOP_LEFT},
        {479, Position.TOP},
        {492, Position.TOP_RIGHT},
        {497, Position.RIGHT},
        {508, Position.CENTER},
        {513, Position.TOP},
        {524, Position.TOP_LEFT},
        {529, Position.LEFT},
        {540, Position.BOTTOM_LEFT},
        {545, Position.LEFT},
        {558, Position.CENTER},
        {563, Position.BOTTOM},
        {574, Position.BOTTOM_RIGHT},
        {579, Position.RIGHT},

        {598, Position.TOP_RIGHT},
        {599, Position.CENTER},
        {606, Position.TOP},
        {607, Position.RIGHT},
        {614, Position.RIGHT},
        {615, Position.BOTTOM},
        {622, Position.CENTER},
        {623, Position.BOTTOM_RIGHT},
        {628, Position.TOP},
        {629, Position.LEFT},
        {636, Position.TOP_LEFT},
        {637, Position.CENTER},
        {644, Position.CENTER},
        {645, Position.BOTTOM_LEFT},
        {652, Position.LEFT},
        {653, Position.BOTTOM},

        {664, Position.BOTTOM_RIGHT},
        {666, Position.BOTTOM_LEFT},
        {668, Position.BOTTOM_RIGHT},
        {670, Position.BOTTOM_LEFT},
        {678, Position.BOTTOM},
        {683, Position.CENTER},
        {693, Position.LEFT},
        {695, Position.RIGHT},
        {697, Position.LEFT},
        {699, Position.RIGHT},
        {707, Position.CENTER},
        {712, Position.TOP},
        {722, Position.TOP_RIGHT},
        {724, Position.TOP_LEFT},
        {726, Position.TOP_RIGHT},
        {727, Position.TOP_LEFT},
        {736, Position.TOP},
        {741, Position.CENTER},

        {753, Position.TOP},
        {755, Position.TOP_RIGHT},
        {757, Position.RIGHT},
        {759, Position.BOTTOM_RIGHT},
        {761, Position.BOTTOM},
        {763, Position.BOTTOM_LEFT},
        {765, Position.LEFT},
        {767, Position.TOP_LEFT},
        {769, Position.TOP},

        {780, Position.TOP},
        {785, Position.BOTTOM_LEFT},
        {790, Position.RIGHT},
        {795, Position.CENTER},
        {800, Position.LEFT},
        {805, Position.BOTTOM_RIGHT},
        {810, Position.TOP},
        {820, Position.TOP},
        {821, Position.LEFT},
        {826, Position.TOP_RIGHT},
        {827, Position.CENTER},
        {828, Position.BOTTOM_LEFT},
        {833, Position.RIGHT},
        {834, Position.BOTTOM},

        {844, Position.RIGHT},
        {845, Position.LEFT},
        {846, Position.RIGHT},
        {847, Position.LEFT},
        {848, Position.RIGHT},
        {849, Position.LEFT},
        {850, Position.RIGHT},
        {851, Position.LEFT},
        {852, Position.RIGHT},
        {853, Position.LEFT},
        {854, Position.RIGHT},
        {855, Position.LEFT},
        {856, Position.RIGHT},
        {857, Position.LEFT},
        {858, Position.RIGHT},
        {859, Position.LEFT},
        {860, Position.RIGHT},
        {861, Position.LEFT},
        {862, Position.RIGHT},
        {863, Position.LEFT},
        {864, Position.RIGHT},
        {865, Position.LEFT},
        {866, Position.RIGHT},
        {867, Position.LEFT},
        {868, Position.RIGHT},
        {869, Position.LEFT},

        {875, Position.TOP},
        {876, Position.CENTER},
        {877, Position.BOTTOM},
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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0)
        {
            PlayerPrefs.SetString("score", "0");
            PlayerPrefs.SetString("combo", "0");
        }

        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            //*if (Random.Range(0, 60) >= 56)
            //{
            //GameObject cube1 = Instantiate(cubePrefab) as GameObject;
            //cube1.transform.position = new Vector3(Random.Range(-1.25f, 1.25f), Random.Range(0, 2), 20);

            //}

            // Do anything
            if (musicfile.ContainsKey(count))
            {
                // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
                GameObject cube = Instantiate(cubePrefab) as GameObject;
                switch (musicfile[count])
                {
                    case Position.TOP_LEFT:
                        cube.transform.position = new Vector3(-1, 1.2f, 20);
                        break;
                    case Position.TOP:
                        cube.transform.position = new Vector3(0, 1.2f, 20);
                        break;
                    case Position.TOP_RIGHT:
                        cube.transform.position = new Vector3(1, 1.2f, 20);
                        break;
                    case Position.LEFT:
                        cube.transform.position = new Vector3(-1, 0.5f, 20);
                        break;
                    case Position.CENTER:
                        cube.transform.position = new Vector3(0, 0.5f, 20);
                        break;
                    case Position.RIGHT:
                        cube.transform.position = new Vector3(1, 0.5f, 20);
                        break;
                    case Position.BOTTOM_LEFT:
                        cube.transform.position = new Vector3(-1, -0.2f, 20);
                        break;
                    case Position.BOTTOM:
                        cube.transform.position = new Vector3(0, -0.2f, 20);
                        break;
                    case Position.BOTTOM_RIGHT:
                        cube.transform.position = new Vector3(1, -0.2f, 20);
                        break;

                }
            }
            count++;
            timeElapsed = 0.0f;
            if (count >= 930)
            {
                SceneManager.LoadScene("ResultScene");
            }
        }
    }

    private void FixedUpdate()
    {
    }
}
