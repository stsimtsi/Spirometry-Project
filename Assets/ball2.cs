using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball2 : MonoBehaviour {
	
private bool isDead = false;
private Rigidbody2D rb2d;
public float speed;
public float scrollSpeed= -1.5f;
private float power;
private float pos;
private bool reach;
private int height;
private GameObject gameObject;
public string myName;
public string myLast;
public int myHeight;
public int myWeight;
	// Use this for initialization
	void Start () {
		rb2d= GetComponent<Rigidbody2D> ();
		
	//Debug.Log("here!"+height);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject=GameObject.Find("dontDestroy");
	  myName=gameObject.GetComponent<dontDestroy>().myName1;
	
	
	myLast=gameObject.GetComponent<dontDestroy>().myLast1;
	
	myHeight=gameObject.GetComponent<dontDestroy>().myHeight1;
	
	
	myWeight=gameObject.GetComponent<dontDestroy>().myWeight1;
	
	if (myHeight<150){
		height=150;
		
		
	}else if(myHeight>=150 && myHeight<170){
		height=200;
	}else{
		height=300;
	}
	
		if (Input.GetKey("space")){
			power++;
			
		}
		if(isDead==false && reach==false){
		/* if(Input.GetKey("right"))
 {
 rb2d.transform.position += transform.right * speed * Time.deltaTime;
 rb2d.transform.position += transform.up * speed * Time.deltaTime;
 //transform.Rotate(Vector3.forward *-100* Time.deltaTime);
 }*/
 if(Input.GetKey("up")){
	 power++;
	// height=500;
	transform.Translate(Vector3.up*power*Time.deltaTime, Space.World);
	if (power>=height){
		reach=true;
		
		
	}
	//transform.position=Vector2(power,0);
	 
 }
		}
		if (isDead==false && reach==true){
			if(Input.GetKey("up")){
			//rb2d.transform.position += transform.up * speed * Time.deltaTime;
			//rb2d.transform.position += transform.right * speed * Time.deltaTime;
			rb2d.AddRelativeForce(Vector2.up * speed*Time.deltaTime);
			//rb2d.AddRelativeForce(Vector2.right* speed*Time.deltaTime);
			 rb2d.transform.eulerAngles = new Vector3(0, 0, -35.0f);
			//rb2d.AddForce(speed*Time.deltaTime,speed*Time.deltaTime);
			}else if(rb2d.transform.position.y<pos){
				rb2d.transform.eulerAngles = new Vector3(0, 0, -145.0f);
				
				//pos=rb2d.transform.position.y;
			}
		rb2d.bodyType = RigidbodyType2D.Dynamic;
		 Vector2 moveDirection = rb2d.velocity;
         if (moveDirection != Vector2.zero ) {
             float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
			 Debug.Log(angle);
             transform.rotation = Quaternion.AngleAxis(-angle, Vector3.forward);
         }
		}
	}
	void OnCollisionEnter2D(Collision2D coll){
		
		 if (coll.gameObject.tag == "Ground"){
		isDead=true;
		GameController.instance.Died();
		
		rb2d.bodyType = RigidbodyType2D.Dynamic;
		 }
	}
	void LateUpdate(){
		
		pos=rb2d.transform.position.y;
	}
	
}
