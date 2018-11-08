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
        {27, Position.CENTER},
        {60, Position.CENTER},
        {93, Position.CENTER},

        {125, Position.TOP_RIGHT},
        {130, Position.TOP},
        {135, Position.TOP_LEFT},
        {158, Position.LEFT},
        {163, Position.CENTER},
        {168, Position.RIGHT},
        {191, Position.BOTTOM_RIGHT},
        {196, Position.BOTTOM},
        {201, Position.BOTTOM_LEFT},
        {223, Position.BOTTOM_LEFT},
        {228, Position.BOTTOM},
        {233, Position.BOTTOM_RIGHT},
        {257, Position.RIGHT},
        {262, Position.CENTER},
        {267, Position.LEFT},
        {289, Position.TOP_LEFT},
        {294, Position.TOP},
        {299, Position.TOP_RIGHT},
        {322, Position.TOP_RIGHT},
        {327, Position.CENTER},
        {332, Position.BOTTOM_LEFT},
        {355, Position.TOP_LEFT},
        {360, Position.CENTER},
        {365, Position.BOTTOM_RIGHT},

        {390, Position.TOP_RIGHT},
        {395, Position.TOP},
        {406, Position.CENTER},
        {411, Position.RIGHT},
        {423, Position.BOTTOM_RIGHT},
        {428, Position.BOTTOM},
        {439, Position.BOTTOM_LEFT},
        {444, Position.BOTTOM},
        {456, Position.CENTER},
        {461, Position.LEFT},
        {472, Position.TOP_LEFT},
        {477, Position.TOP},
        {487, Position.TOP_RIGHT},
        {492, Position.RIGHT},
        {503, Position.CENTER},
        {508, Position.TOP},
        {519, Position.TOP_LEFT},
        {524, Position.LEFT},
        {535, Position.BOTTOM_LEFT},
        {540, Position.LEFT},
        {553, Position.CENTER},
        {558, Position.BOTTOM},
        {569, Position.BOTTOM_RIGHT},
        {574, Position.RIGHT},

        {592, Position.TOP_RIGHT},
        {594, Position.CENTER},
        {599, Position.TOP},
        {600, Position.RIGHT},
        {606, Position.RIGHT},
        {607, Position.BOTTOM},
        {614, Position.CENTER},
        {615, Position.BOTTOM_RIGHT},
        {623, Position.TOP},
        {624, Position.LEFT},
        {629, Position.TOP_LEFT},
        {630, Position.CENTER},
        {637, Position.CENTER},
        {638, Position.BOTTOM_LEFT},
        {645, Position.LEFT},
        {646, Position.BOTTOM},

        {657, Position.BOTTOM_RIGHT},
        {659, Position.BOTTOM_LEFT},
        {661, Position.BOTTOM_RIGHT},
        {664, Position.BOTTOM_LEFT},
        {671, Position.BOTTOM},
        {676, Position.CENTER},
        {686, Position.LEFT},
        {688, Position.RIGHT},
        {690, Position.LEFT},
        {694, Position.RIGHT},
        {700, Position.CENTER},
        {705, Position.TOP},
        {715, Position.TOP_RIGHT},
        {717, Position.TOP_LEFT},
        {719, Position.TOP_RIGHT},
        {721, Position.TOP_LEFT},
        {729, Position.TOP},
        {734, Position.CENTER},

        {744, Position.TOP},
        {746, Position.TOP_RIGHT},
        {748, Position.RIGHT},
        {750, Position.BOTTOM_RIGHT},
        {752, Position.BOTTOM},
        {754, Position.BOTTOM_LEFT},
        {756, Position.LEFT},
        {758, Position.TOP_LEFT},
        {760, Position.TOP},

        {773, Position.TOP},
        {778, Position.BOTTOM_LEFT},
        {783, Position.RIGHT},
        {788, Position.CENTER},
        {793, Position.LEFT},
        {798, Position.BOTTOM_RIGHT},
        {803, Position.TOP},
        {813, Position.TOP},
        {814, Position.LEFT},
        {819, Position.TOP_RIGHT},
        {820, Position.CENTER},
        {821, Position.BOTTOM_LEFT},
        {826, Position.RIGHT},
        {827, Position.BOTTOM},

        {837, Position.RIGHT},
        {838, Position.LEFT},
        {839, Position.RIGHT},
        {840, Position.LEFT},
        {841, Position.RIGHT},
        {842, Position.LEFT},
        {843, Position.RIGHT},
        {844, Position.LEFT},
        {845, Position.RIGHT},
        {846, Position.LEFT},
        {847, Position.RIGHT},
        {848, Position.LEFT},
        {849, Position.RIGHT},
        {850, Position.LEFT},
        {851, Position.RIGHT},
        {852, Position.LEFT},
        {853, Position.RIGHT},
        {854, Position.LEFT},
        {855, Position.RIGHT},
        {856, Position.LEFT},
        {857, Position.RIGHT},
        {858, Position.LEFT},
        {859, Position.RIGHT},
        {860, Position.LEFT},
        {861, Position.RIGHT},
        {862, Position.LEFT},
   
        {868, Position.TOP},
        {869, Position.CENTER},
        {870, Position.BOTTOM},
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
