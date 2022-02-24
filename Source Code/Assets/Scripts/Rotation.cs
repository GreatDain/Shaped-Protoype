using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public GameObject[] B1;
    public GameObject[] S1;
    public GameObject[] S2;
    public GameObject[] S34;
    public GameObject[] B4;
    public GameObject[] T2;
    public GameObject[] T1;
    public Quaternion target;
    public float move = 1f;
    private AudioSource source;

	void Start () {
        target = transform.rotation;
        source = GetComponent<AudioSource>();
	}
	
	void Update ()
    {
		if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "B1")
                {
                    foreach (GameObject B1 in B1)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.forward);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "S1")
                {
                    foreach (GameObject S1 in S1)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.forward);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "S2")
                {
                    foreach (GameObject S2 in S2)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.up);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "S3" || hit.transform.gameObject.tag == "S4")
                {
                    foreach (GameObject S3 in S34)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.forward);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "B4")
                {
                    foreach (GameObject B4 in B4)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.up);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "T2")
                {
                    foreach (GameObject T2 in T2)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.up);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "T1" || hit.transform.gameObject.tag == "B2")
                {
                    foreach (GameObject T1 in T1)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.up);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "B2")
                {
                    foreach (GameObject T1 in T1)
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
