using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeoutPointTextScript : MonoBehaviour {

    void Start()
    {
    }

    void Update()
    {
        Color color = transform.GetComponent<Renderer>().material.color;
        if (color.a > 0f)
        {
            color.a -= 0.03f;
            transform.GetComponent<Renderer>().material.color = color;
            transform.position += new Vector3(0, 0.02f, 0);
        } else
        {
            Destroy(gameObject);
        }
    }
}
