using UnityEngine;
using System;
using System.Collections;

public class EnemyHumanGunController : MonoBehaviour {

    private float angle = 2;
    public int rayRadius;
    public float GunAngle;
    public float TurretAngle;
    public Transform Turret;
    private RaycastHit2D hit;

	// Use this for initialization
	void Start () 
    {
        rayRadius = 10;
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Raycasting();
	}

    void FixedUpdate()
    {
        Raycasting();
    }

    void Raycasting()
    {
        // смена конечной точки
        angle += 0.025f;
        if (angle >= 3.57) angle = 2;
        Vector3 direction = new Vector3((float)Math.Cos(angle) * rayRadius, (float)Math.Sin(angle) * rayRadius, 0);

        if (Physics2D.Linecast(this.transform.position, this.transform.position + new Vector3(-2, 0, 0) + direction, 1 << LayerMask.NameToLayer("Player")))
        {
            Vector3 rotationVector = new Vector3(0, 0, angle * 57 + 180);
            transform.rotation = Quaternion.Euler(rotationVector);
        }
        //Debug.DrawLine(this.transform.position + new Vector3(-2, 0, 0), this.transform.position + new Vector3(-2, 0, 0) + direction, Color.green);
    }
}
