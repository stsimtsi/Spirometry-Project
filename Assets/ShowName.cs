using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour {
public GameObject Sname;
public GameObject Slastname;
	// Use this for initialization
	void Start () {
		Sname.GetComponent<Text>().text=GameData.namePlayer;
		Slastname.GetComponent<Text>().text=GameData.lastnamePlayer;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
