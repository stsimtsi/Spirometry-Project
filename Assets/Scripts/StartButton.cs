﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {
    public GameObject counting;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CloseCounting()
    {
        
        counting.GetComponent<Animator>().SetBool("finishCounting", true);
    }
}
