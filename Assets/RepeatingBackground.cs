using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {
private BoxCollider2D groundCollider;
private float groundHorizontalLength;
public GameObject player;
float distance;
public GameObject ground;
	// Use this for initialization
	void Start () {
		groundCollider=GetComponent<BoxCollider2D> ();
		groundHorizontalLength= groundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		distance=Vector2.Distance(player.transform.position,transform.position);
		if(distance>100){
			RepositionBackground();
		}
	}
	
	private void RepositionBackground(){
		
		Vector2 groundOffset= new Vector2 (groundHorizontalLength*2f,0);
		transform.position= (Vector2)transform.position + groundOffset;
	}
}
