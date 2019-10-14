using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backScript : MonoBehaviour {
//public GameObject stopPoint;
public bool stopMoving;
	// Use this for initialization
	void Start () {
		stopMoving=false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D coll){
		if(coll.gameObject.tag=="stop"){
		stopMoving=true;
		Debug.Log("okkkkkkkkkkkkkkkrrrrrrrrrrr");
		}
	}
}
