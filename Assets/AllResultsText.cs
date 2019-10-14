using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllResultsText : MonoBehaviour {

public GameObject ResText;
public GameObject AllRes;
public GameObject StartButton;
public GameObject Charts;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameData.LoadUserInformation();
		ResText.GetComponent<Text>().text=GameData.allResultsText;
	}
	
	
	public void ShowAllResults(){
		
		AllRes.SetActive(true);
		StartButton.SetActive(false);
	}
	
	public void BackMenu(){
		
		AllRes.SetActive(false);
		StartButton.SetActive(true);
		
	}
	public void ShowCharts(){
		Charts.SetActive(true);
		
	}
	public void BackCharts(){
		Charts.SetActive(false);
		
	}
}
