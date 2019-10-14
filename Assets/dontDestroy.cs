using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour {

private GameObject gameObject;
public string myName1;
public string myLast1;
public int myHeight1;
public int myWeight1;
public string sexChoice;
public string ethnicityChoice;
private int lifes=3;

private void Start(){
	
	PlayerPrefs.SetInt("lifes", lifes);
	Debug.Log(GameData.test);
	
	
}

private void Update(){
	
	AudioListener.volume=PlayerPrefs.GetFloat("listener");
	gameObject=GameObject.Find("inputMenu");
	if(gameObject!=null){
	  myName1=gameObject.GetComponent<InputScript>().myName;
	  PlayerPrefs.SetString("myName",myName1);
	  GameData.namePlayer=myName1;
	//Debug.Log(myName1);
	
	myLast1=gameObject.GetComponent<InputScript>().myLast;
	PlayerPrefs.SetString("myLast",myLast1);
	GameData.lastnamePlayer=myLast1;
	//Debug.Log(myLast1);
	
	myHeight1=gameObject.GetComponent<InputScript>().myHeight;
	PlayerPrefs.SetInt("height",myHeight1);
	Patient.height=myHeight1;
	//Debug.Log(PlayerPrefs.GetInt("myHeight",myHeight1));
	
	myWeight1=gameObject.GetComponent<InputScript>().myWeight;
	PlayerPrefs.SetInt("weight",myWeight1);
	Patient.weight=myWeight1;
	//Debug.Log(myWeight1);
	
	 sexChoice=gameObject.GetComponent<sexScript>().sex;
	  PlayerPrefs.SetString("sex",sexChoice);
	  GameData.genderString=sexChoice;
	  
	  ethnicityChoice=gameObject.GetComponent<sexScript>().ethnicity;
	  PlayerPrefs.SetString("ethnicity",ethnicityChoice);
	  GameData.ethnicityString=ethnicityChoice;
	}
}


	// Use this for initialization
	//void Awake() {
//  DontDestroyOnLoad(this);
//}
}
