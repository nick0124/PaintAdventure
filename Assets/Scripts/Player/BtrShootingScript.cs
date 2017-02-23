
using UnityEngine;
using System.Collections;

public class BtrShootingScript : MonoBehaviour
{
    public Transform bullet;
    public Rigidbody2D carHull;
    public int bulletForce;
    public int curAmmoCount;
    public int patron;
    public float speed = 20f;
    public float burstTime;
    public Vector2 direction;
    //public characterController characterCtrl;// The speed the shot will fire at.

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (burstTime > 0)
            burstTime -= Time.deltaTime;

        direction = this.transform.right;
        // If the fire button is pressed...
        if (Input.GetMouseButton(0) && burstTime <= 0)
        {
            Shot();
            /*
            audio.Play();
            Transform bulletInstance = (Transform)Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0, 0, this.transform.eulerAngles.z)));
            bulletInstance.rigidbody2D.velocity = new Vector2(carHull.transform.rigidbody2D.velocity.x + 20 * direction.x, 20 * direction.y);
            curAmmoCount -= 1;
            // ... instantiate the rocket facing right and set it's velocity to the right. 
            Rigidbody2D bulletInstance = Instantiate(shot, transform.position, Quaternion.Euler(new Vector3(0, 0, this.transform.eulerAngles.z))) as Rigidbody2D;
            bulletInstance.velocity = new Vector2(carHull.transform.rigidbody2D.velocity.x + 20 * direction.x, 20 * direction.y);
             */
        }

    }

    private void Shot()
    {
        GetComponent<AudioSource>().Play();
        burstTime = 0.1f;
        Transform bulletInstance = (Transform)Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0, 0, this.transform.eulerAngles.z)));
        bulletInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(carHull.transform.GetComponent<Rigidbody2D>().velocity.x + 20 * direction.x, 20 * direction.y);
        curAmmoCount -= 1;
        /*
        // ... instantiate the rocket facing right and set it's velocity to the right. 
        Rigidbody2D bulletInstance = Instantiate(shot, transform.position, Quaternion.Euler(new Vector3(0, 0, this.transform.eulerAngles.z))) as Rigidbody2D;
        bulletInstance.velocity = new Vector2(carHull.transform.rigidbody2D.velocity.x + 20 * direction.x, 20 * direction.y);
         */

    }
}


