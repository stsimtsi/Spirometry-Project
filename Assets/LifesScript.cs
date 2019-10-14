using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifesScript : MonoBehaviour {
	
	public GameObject life1;
	public GameObject life2;
	public GameObject life3;
	public GameObject restart;
	

	// Use this for initialization
	void Start () {
		Debug.Log(PlayerPrefs.GetInt("lifes"));
		
		if(PlayerPrefs.GetInt("lifes")<3){
			life3.SetActive(false);
			
		}
		if(PlayerPrefs.GetInt("lifes")<2){
			
			life2.SetActive(false);
			
		}
		if(PlayerPrefs.GetInt("lifes")<1){
			
			restart.SetActive(false);
			
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
