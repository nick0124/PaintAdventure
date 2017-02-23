using UnityEngine;
using System.Collections;

public class EnemyPlaneScript : MonoBehaviour {

    public bool hit = false;
    public bool explose = false;
    public float speed;
    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () 
    {
        speed = -10;
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        //rigidbody2D.AddForce(new Vector2(speed, 0));
	}

    /*
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            hit = true;
            rigidbody2D.gravityScale = 5;
            speed = 0;
        }
    }
     */
     
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider2D>().isTrigger = false;
            hit = true;
            GetComponent<Rigidbody2D>().gravityScale = 5;
            speed = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag != "Bullet" && hit)
        {
            explose = true;
            spriteRenderer.enabled = false;
            Destroy(gameObject, 2);
        }
    }
}
