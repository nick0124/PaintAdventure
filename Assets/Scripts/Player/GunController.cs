﻿using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

    //public Transform GunBegin;
    public Transform Turret;
    private Vector3 mouse_pos;
	private Vector3 object_pos;
    private float maxAngle;
    private float minAngle;
	private float angle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        //
        mouse_pos = Input.mousePosition;
        mouse_pos.z = 0.0f;
        object_pos = Camera.main.WorldToScreenPoint(transform.position);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        if (angle > 90) angle = 90;
        if (angle < 0) angle = 0;
        Vector3 rotationVector = new Vector3(0, 0, angle);
        transform.rotation = Quaternion.Euler(rotationVector);
    }
}
