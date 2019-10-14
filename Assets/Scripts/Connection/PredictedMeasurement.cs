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
public class PredictedMeasurement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(GameData.predictedPercentageOfTarget==0.0)
        {

            transform.GetComponent<Text>().text = "";
        }

        else
        {
            transform.GetComponent<Text>().text = GameData.predictedPercentageOfTarget.ToString();
        }
        

    }
}
