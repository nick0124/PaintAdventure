using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {

    public Rigidbody2D shot;				// Prefab of the shot.
    public Rigidbody2D carHull;
    public float speed = 20f;
    public Vector2 direction;
    //public characterController characterCtrl;// The speed the shot will fire at.

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        direction = this.transform.right;
        // If the fire button is pressed...
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<AudioSource>().Play();
            // ... instantiate the rocket facing right and set it's velocity to the right. 
            Rigidbody2D bulletInstance = Instantiate(shot, transform.position, Quaternion.Euler(new Vector3(0, 0, this.transform.eulerAngles.z))) as Rigidbody2D;
            bulletInstance.velocity = new Vector2(carHull.transform.GetComponent<Rigidbody2D>().velocity.x + 20 * direction.x, 20 * direction.y);
        }
    }
}
