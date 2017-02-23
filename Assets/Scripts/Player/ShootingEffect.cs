using UnityEngine;
using System.Collections;

public class ShootingEffect : MonoBehaviour {

    private Animator Anim;


	// Use this for initialization
	void Start () 
    {
	    Anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Anim.SetTrigger("Shoot");
        }
        else
        {
            Anim.ResetTrigger("Shoot");
        }

	}
}
