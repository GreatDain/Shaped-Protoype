using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Menu : MonoBehaviour {

    private AudioSource source;

    void Start () {
        source = GetComponent<AudioSource>();
    }

	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Start")
                {
                    source.Play();
                    Invoke("PlayGame", 1.5f);
                }

                if (hit.transform.gameObject.tag == "Quit")
                {
                    Application.Quit();
                }
            }
        }
	}

    void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
