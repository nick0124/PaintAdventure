using UnityEngine;
using System.Collections;

public class EnemuHumanScript : MonoBehaviour {

    //public Animator anim;


	// Use this for initialization
	void Start () 
    {
        //anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider2D>().isTrigger = true;
            GetComponent<CircleCollider2D>().isTrigger = true;
            //anim.SetTrigger("Dead");
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider2D>().isTrigger = true;
            GetComponent<CircleCollider2D>().isTrigger = true;
            //anim.SetTrigger("Dead");
        }

    }

    /*
    public void Die()
    {
        Destroy(gameObject);
    }
     */
}
