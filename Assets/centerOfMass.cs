﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centerOfMass : MonoBehaviour {
public Vector2 com;
    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
        rb.centerOfMass = com;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
