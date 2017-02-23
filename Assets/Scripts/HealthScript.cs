using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public int Health = 1;
    public int LiveAfterHit = 0;
    public bool isEnemy = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void Damage(int damageCount)
    {
        Health -= damageCount;

        if (Health <= 0)
        {
            // Dead!
            Destroy(gameObject, LiveAfterHit);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        // Is this a shot?
        BulletScript shot = coll.gameObject.GetComponent<BulletScript>();
        if (shot != null)
        {
                Damage(shot.Damage);
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
    //human enemy die
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            audio.Play();
            GetComponent<BoxCollider2D>().isTrigger = true;
            GetComponent<CircleCollider2D>().isTrigger = true;
            //anim.SetTrigger("Dead");
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            audio.Play();
            GetComponent<BoxCollider2D>().isTrigger = true;
            GetComponent<CircleCollider2D>().isTrigger = true;
            //anim.SetTrigger("Dead");
        }

    }

    //plane enemy die
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            audio.Play();
            GetComponent<BoxCollider2D>().isTrigger = false;
            hit = true;
            rigidbody2D.gravityScale = 5;
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
      
    void OnTriggerEnter2D(Collider2D otherCollider)
  {
    // Is this a shot?
    ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
    if (shot != null)
    {
      // Avoid friendly fire
      if (shot.isEnemyShot != isEnemy)
      {
        Damage(shot.damage);

        // Destroy the shot
        Destroy(shot.gameObject); // Remember to always target the game object, otherwise you will just remove the script
      }
    } 
     */
}
