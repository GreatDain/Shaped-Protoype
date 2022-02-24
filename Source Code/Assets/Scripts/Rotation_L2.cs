using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_L2 : MonoBehaviour {

    public GameObject[] T1;
    public GameObject[] T2;
    public GameObject[] T3;
    public GameObject[] T4;
    public GameObject[] T5;
    public GameObject[] Left;
    public GameObject[] Right;
    public GameObject[] RB;
    public GameObject[] LB;
    public GameObject[] FB;
    public GameObject[] BB;
    public GameObject[] FV;
    public GameObject[] BV;
    public Quaternion target;
    public float move = 1f;
    private AudioSource source;

    void Start () {
        target = transform.rotation;
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "T2")
                {
                    foreach (GameObject T2 in T2)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.forward);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "T4")
                {
                    foreach (GameObject T4 in T4)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.forward);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "T3")
                {
                    foreach (GameObject T3 in T3)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.up);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "Left")
                {
                    foreach (GameObject Left in Left)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.down);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "Right")
                {
                    foreach (GameObject Right in Right)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.back);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "RB")
                {
                    foreach (GameObject RB in RB)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.back);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "LB")
                {
                    foreach (GameObject LB in LB)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.right);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "T5")
                {
                    foreach (GameObject T5 in T5)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.up);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "FB")
                {
                    foreach (GameObject FB in FB)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.forward);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "BB")
                {
                    foreach (GameObject BB in BB)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.down);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "FV" || hit.transform.gameObject.tag == "T1")
                {
                    foreach (GameObject FV in FV)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.right);
                        source.Play();
                    }
                }
            }
        }
        gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, target, 10 * move * Time.deltaTime);
    }
}
