using UnityEngine;
using System.Collections;

public class MotorScript : MonoBehaviour {

    private float move;
    public int Force = 100;

    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().AddForceAtPosition(new Vector2(0, -move * Force), new Vector2(1, 0));
        GetComponent<Rigidbody2D>().AddForceAtPosition(new Vector2(0, move * Force), new Vector2(-1, 0));
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	}
}
