using UnityEngine;
using System.Collections;

public class CurentLvlScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //PlayerPrefs.SetInt("CurrentLVL", Application.loadedLevel);
	}
	
	// Update is called once per frame
	void Update () {
        	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        PlayerPrefs.SetInt("CurrentLVL", Application.loadedLevel);
    }

    void OnMouseDown()
    {
        PlayerPrefs.SetInt("CurrentLVL", PlayerPrefs.GetInt("CurrentLVL") + 1);
        if (PlayerPrefs.GetInt("CurrentLVL") < 3)
        {
            Application.LoadLevel(PlayerPrefs.GetInt("CurrentLVL"));
        }
        else
        {
            Application.LoadLevel(0);
        }
    }
}
