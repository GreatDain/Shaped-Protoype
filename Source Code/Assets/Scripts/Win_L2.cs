using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win_L2 : MonoBehaviour {

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
		if ((parts[0].transform.rotation.eulerAngles.z >= 347 || parts[0].transform.rotation.eulerAngles.z <= 193)
            && (parts[1].transform.rotation.eulerAngles.z >= 347 || (parts[1]).transform.rotation.eulerAngles.z < 168 && parts[1].transform.rotation.eulerAngles.z > 167)
            && (parts[2].transform.rotation.eulerAngles.x >= 358 || parts[2].transform.rotation.eulerAngles.x <= 2)
            && (parts[3].transform.rotation.eulerAngles.z >= 347 || (parts[3]).transform.rotation.eulerAngles.z < 168 && parts[3].transform.rotation.eulerAngles.z > 167)
            && (parts[4].transform.rotation.eulerAngles.x >= 358 || parts[4].transform.rotation.eulerAngles.x <= 2)
            && (parts[5].transform.rotation.eulerAngles.x >= 358 || parts[5].transform.rotation.eulerAngles.x <= 2)
            && (parts[6].transform.rotation.eulerAngles.z >= 347 || (parts[6]).transform.rotation.eulerAngles.z < 168 && parts[6].transform.rotation.eulerAngles.z > 167)
            && ((parts[7].transform.rotation.eulerAngles.z >= 264 && parts[7].transform.rotation.eulerAngles.z <= 265) || (parts[7].transform.rotation.eulerAngles.z >= 84 && parts[7].transform.rotation.eulerAngles.z <= 85))
            && ((parts[8].transform.rotation.eulerAngles.x >= 282 && parts[8].transform.rotation.eulerAngles.x <= 283) || (parts[8].transform.rotation.eulerAngles.x >= 77 && parts[8].transform.rotation.eulerAngles.x <= 78))
            && ((parts[9].transform.rotation.eulerAngles.z >= 354 && parts[8].transform.rotation.eulerAngles.z <= 355) || (parts[9].transform.rotation.eulerAngles.z >= 174 && parts[9].transform.rotation.eulerAngles.z <= 175))
            && (parts[10].transform.rotation.eulerAngles.z >= 174 && parts[10].transform.rotation.eulerAngles.z <= 186)
            && (parts[11].transform.rotation.eulerAngles.z >= 88 && parts[11].transform.rotation.eulerAngles.z <= 92)
            && (win == 0))
        {
            //Debug.Log("win");
            win = 1;
            source.Play();
            if (win == 1)
            {
                winText.enabled = true;
                win = 2;
                Invoke("NextLevel", 3.5f);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //Debug.Log(parts[11].transform.rotation.eulerAngles.z);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(0);
    }
}
