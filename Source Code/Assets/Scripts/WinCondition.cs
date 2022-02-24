using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour {

    public GameObject[] parts;
    public Text winText;
    private int win;
    private AudioSource source;

    void Start () {
        win = 0;
        winText.enabled = false;
        source = GetComponent<AudioSource>();
    }
	
	void Update () {
        if ((parts[0].transform.rotation.eulerAngles.z <= 0 || parts[0].transform.rotation.eulerAngles.z == 180)
            && (parts[1].transform.rotation.eulerAngles.y <= 0 || parts[1].transform.rotation.eulerAngles.y == 180)
            && (parts[2].transform.rotation.eulerAngles.y == 270f || (parts[2].transform.rotation.eulerAngles.y > 89f && parts[2].transform.rotation.eulerAngles.y <= 90f))
            && (parts[3].transform.rotation.eulerAngles.z == 270f || (parts[3].transform.rotation.eulerAngles.z > 89f && parts[3].transform.rotation.eulerAngles.z <= 90f))
            && (parts[4].transform.rotation.eulerAngles.x <= 1)
            && (parts[5].transform.rotation.eulerAngles.z == 270f || (parts[5].transform.rotation.eulerAngles.z > 89f && parts[5].transform.rotation.eulerAngles.z <= 90f))
            && (parts[6].transform.rotation.eulerAngles.z == 270f || (parts[6].transform.rotation.eulerAngles.z > 89f && parts[6].transform.rotation.eulerAngles.z <= 90f))
            && (parts[7].transform.rotation.eulerAngles.y == 270f || (parts[7].transform.rotation.eulerAngles.y > 89f && parts[7].transform.rotation.eulerAngles.y <= 90f))
            && (parts[8].transform.rotation.eulerAngles.x <= 1 || (parts[8].transform.rotation.eulerAngles.x > 89f && parts[8].transform.rotation.eulerAngles.x <= 90)) 
            && (win == 0))
        {
            win = 1;
            source.Play();
            if (win == 1)
            {
                winText.enabled = true;
                win = 2;
                Invoke("NextLevel", 3.5f);
            }
            //Debug.Log("Win");
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            winText.enabled = true;
            Invoke("NextLevel", 3.5f);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //Debug.Log(parts[8].transform.rotation.eulerAngles.x);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(3);
    }
}
