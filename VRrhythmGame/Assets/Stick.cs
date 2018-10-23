using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public GameObject scoreText;

    public GameObject comboText;

    public Material capMaterial;

    private Vector3 beforePos;
    //private AudioSource audioSource;
    //public AudioClip saber;

    void Start ()
    {
        //audioSource = gameObject.GetComponent<AudioSource>();
        beforePos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Math.Abs(beforePos.x + beforePos.y + beforePos.z - transform.position.x - transform.position.y - transform.position.z) > 0.1)
        {
            //audioSource.PlayOneShot(saber, 1);
        }
        beforePos = transform.position;
        
	}

    private IEnumerator DelayMethod(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Cube")
        {
            GameObject victim = collision.gameObject;
            victim.GetComponent<Rigidbody>().useGravity = true;

            Vector3 before = transform.position;

            collision.gameObject.tag = "Untagged";

            StartCoroutine(DelayMethod(0.001f, () =>
            {

                var pos = transform.position - before;

                if (pos != new Vector3(0, 0, 0))
                {

                    var center = collision.gameObject.GetComponent<Renderer>().bounds.center;

                    var tmp = pos.x;
                    pos.x = pos.y;
                    pos.y = tmp;
                    pos.z = 0;

                    if (Math.Abs(pos.x) > Math.Abs(pos.y))
                    {
                        if (pos.x > 0)
                        {
                            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
                            Debug.Log("up");
                        }
                        else
                        {
                            collision.gameObject.GetComponent<Renderer>().material.color = Color.blue;
                            Debug.Log("bottom");
                        }
                        pos.x = 1.0f;
                        pos.y = 0;
                    }
                    else
                    {
                        if (pos.y > 0)
                        {
                            collision.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                            Debug.Log("left");
                        }
                        else
                        {
                            collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
                            Debug.Log("right");
                        }
                        pos.x = 0;
                        pos.y = 1.0f;
                    }

                    comboText.GetComponent<TextMesh>().text = (Int32.Parse(comboText.GetComponent<TextMesh>().text) + 1).ToString();
                    Double comboBonus = Int32.Parse(comboText.GetComponent<TextMesh>().text) > 5 ? Int32.Parse(comboText.GetComponent<TextMesh>().text) * 0.01 : 0;
                    scoreText.GetComponent<TextMesh>().text = (Int32.Parse(scoreText.GetComponent<TextMesh>().text) + Math.Floor(100 * (1 + comboBonus))).ToString();

                    GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, center, pos, capMaterial);
                    // before
                    //GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, center, (transform.position - before) == new Vector3(0, 0, 0) ? transform.forward : pos, capMaterial);

                    if (!pieces[1].GetComponent<Rigidbody>())
                        pieces[1].AddComponent<Rigidbody>();

                    pieces[1].GetComponent<Transform>().position -= new Vector3(0.01f, 0f, 1f * Time.deltaTime);

                    Destroy(pieces[1], 1);
                }

            }));

        }


    }
}
