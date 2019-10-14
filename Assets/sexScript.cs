using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sexScript : MonoBehaviour {
	public GameObject girlButton;
	public GameObject boyButton;
	public string sex;
	public GameObject ethn;
	public GameObject ethn1;
	public GameObject ethn2;
	public GameObject ethn3;
	public GameObject ethn4;
	public string ethnicity;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if(girlButton.GetComponent<Toggle>().isOn = true;
	
		
		
	}
	public void SexBoyFunction(){
		girlButton.GetComponent<Image>().color=new Color32(255,255,225,100);;
		boyButton.GetComponent<Image>().color=Color.white;
		girlButton.GetComponent<Toggle>().isOn = false;
		sex="boy";
		Debug.Log(sex);
		Patient.gender=0;
	}
	public void SexGirlFunction(){
		boyButton.GetComponent<Image>().color=new Color32(255,255,225,100);;
		girlButton.GetComponent<Image>().color=Color.white;
		boyButton.GetComponent<Toggle>().isOn = false;
		sex="girl";
		Debug.Log(sex);
		Patient.gender=1;
	}
	public void EthnicityFunction(){
		ethn.GetComponent<Image>().color=Color.white;
		ethn1.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn2.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn3.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn4.GetComponent<Image>().color=new Color32(255,255,255,100);
		//ethn.GetComponent<Toggle>().isOn = true;
		ethn1.GetComponent<Toggle>().isOn = false;
		ethn2.GetComponent<Toggle>().isOn = false;
		ethn3.GetComponent<Toggle>().isOn = false;
		ethn4.GetComponent<Toggle>().isOn = false;
		ethnicity="europian";
		Patient.ethnicity=18;
		
	}
	public void Ethnicity1Function(){
		ethn1.GetComponent<Image>().color=Color.white;
		ethn.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn2.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn3.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn4.GetComponent<Image>().color=new Color32(255,255,255,100);
		//ethn1.GetComponent<Toggle>().isOn = true;
		ethn.GetComponent<Toggle>().isOn = false;
		ethn2.GetComponent<Toggle>().isOn = false;
		ethn3.GetComponent<Toggle>().isOn = false;
		ethn4.GetComponent<Toggle>().isOn = false;
		ethnicity="africanamerican";
		Patient.ethnicity=19;
		
	}
	public void Ethnicity2Function(){
		ethn2.GetComponent<Image>().color=Color.white;
		ethn1.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn3.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn4.GetComponent<Image>().color=new Color32(255,255,255,100);
		//ethn2.GetComponent<Toggle>().isOn = true;
		ethn1.GetComponent<Toggle>().isOn = false;
		ethn.GetComponent<Toggle>().isOn = false;
		ethn3.GetComponent<Toggle>().isOn = false;
		ethn4.GetComponent<Toggle>().isOn = false;
		ethnicity="mongol";
		Patient.ethnicity=20;
	}
	public void Ethnicity3Function(){
		ethn3.GetComponent<Image>().color=Color.white;
		ethn1.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn2.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn4.GetComponent<Image>().color=new Color32(255,255,255,100);
		//ethn3.GetComponent<Toggle>().isOn = true;
		ethn1.GetComponent<Toggle>().isOn = false;
		ethn2.GetComponent<Toggle>().isOn = false;
		ethn.GetComponent<Toggle>().isOn = false;
		ethn4.GetComponent<Toggle>().isOn = false;
		ethnicity="chinese";
		Patient.ethnicity=21;
	}
	public void Ethnicity4Function(){
		ethn4.GetComponent<Image>().color=Color.white;
		ethn1.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn2.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn3.GetComponent<Image>().color=new Color32(255,255,255,100);
		ethn.GetComponent<Image>().color=new Color32(255,255,255,100);
		//ethn4.GetComponent<Toggle>().isOn = true;
		ethn1.GetComponent<Toggle>().isOn = false;
		ethn2.GetComponent<Toggle>().isOn = false;
		ethn3.GetComponent<Toggle>().isOn = false;
		ethn.GetComponent<Toggle>().isOn = false;
		ethnicity="other";
		Patient.ethnicity=22;
	}
}

	
