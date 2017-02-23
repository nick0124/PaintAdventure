using UnityEngine;
using System.Collections;

public class EffectScript : MonoBehaviour {

    public bool hit = false;
    public bool dead = false;
    public EnemyPlaneScript enemy;
    Animator anim;

	// Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        //hit = GameObject.Find("Plane").GetComponent<EnemyPlaneScript>().hit;
        hit = enemy.hit;
        //dead = GameObject.Find("Plane").GetComponent<EnemyPlaneScript>().explose;
        dead = enemy.explose;

        if (hit)
        {
           anim.SetTrigger("Shoot");
        }
        else
        {
            anim.ResetTrigger("Shoot");
        }
        if (hit & dead)
        {
            anim.ResetTrigger("Shoot");
            anim.SetTrigger("Explose");
        }
	
	}
}
