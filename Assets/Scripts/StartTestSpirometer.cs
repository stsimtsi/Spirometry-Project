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

using UnityEngine.EventSystems;
using System.Threading;

public class StartTestSpirometer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    //Start the test when push the button OK
    public void StartTestSpirometerFunction()
    {
       

		GameData.testStarted=true;
        var ajc = new AndroidJavaClass("com.example.mysdk.Unity");
        Debug.Log("----> STARTING TEST");
        ajc.CallStatic("begin", Patient.birthday, Patient.height, Patient.weight, Patient.gender, Patient.ethnicity);
    }
}
