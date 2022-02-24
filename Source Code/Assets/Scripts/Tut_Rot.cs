using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tut_Rot : MonoBehaviour {

    public GameObject[] S_T;
    public GameObject[] S_B;
    public GameObject[] T_B;
    public GameObject[] T_T;
    public GameObject[] A_L;
    public GameObject[] A_R;
    public GameObject[] A_M;
    public GameObject[] R_L;
    public GameObject[] R_T;
    public GameObject[] R_B;
    public GameObject[] T2_B;
    public GameObject[] T2_T;
    public Quaternion target;
    public float move = 1f;
    private AudioSource source;

    void Start () {
        target = transform.rotation;
        source = GetComponent<AudioSource>();
    }

	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "S_T")
                {
                    foreach (GameObject S_T in S_T)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.forward);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "S_B")
                {
                    foreach (GameObject S_B in S_B)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.forward);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "T_B" || hit.transform.gameObject.tag == "R_L")
                {
                    foreach (GameObject T_B in T_B)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.right);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "A_L")
                {
                    foreach (GameObject A_L in A_L)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.left);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "A_R")
                {
                    foreach (GameObject A_R in A_R)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.up);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "T2_B")
                {
                    foreach (GameObject T2_B in T2_B)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.up);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "R_B")
                {
                    foreach (GameObject R_B in R_B)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.right);
                        source.Play();
                    }
                }
                if (hit.transform.gameObject.tag == "R_T")
                {
                    foreach (GameObject R_T in R_T)
                    {
                        target *= Quaternion.AngleAxis(90f, Vector3.forward);
                        source.Play();
                    }
                }
            }
        }
        gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, target, 10 * move * Time.deltaTime);
    }
}
