using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicMute : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	public void MuteAudio(){
		
		
		if(PlayerPrefs.GetFloat("listener")==1f){
		PlayerPrefs.SetFloat("listener",0f);
		}else{
		PlayerPrefs.SetFloat("listener",1f);
		}
		
		
	}
}
