using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using System.Xml;
using UnityEngine.UI;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
using UnityEngine.SceneManagement;

public class TextConnection : MonoBehaviour {
    public GameObject rotationImage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(!GameData.connectedBluetooth)
        {
            transform.GetComponent<Text>().text = "Try to connect...";
            rotationImage.GetComponent<Image>().color = Color.red;
            transform.GetComponent<Text>().color = Color.red;
           

        }
        else if(GameData.connectedBluetooth)
        {
            transform.GetComponent<Text>().text = "Connected";
            rotationImage.GetComponent<Image>().color = Color.green;
            transform.GetComponent<Text>().color = Color.green;
           
        }
		
	}
}
