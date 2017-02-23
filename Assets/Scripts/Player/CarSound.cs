using UnityEngine;
using System.Collections;

public class CarSound : MonoBehaviour {

    public AudioSource engineWorkSound;
    public AudioSource engineIdlekSound;


    public float move;


	// Use this for initialization
	void Start () {
        engineWorkSound.Stop();
        engineIdlekSound.Play();
	}
	
	// Update is called once per frame
    void Update()
    {
        move = Mathf.Abs(Input.GetAxis("Horizontal"));
        engineIdlekSound.pitch = 0.5f + move * 1.2f;

    }
}
