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

public class Bar1 : MonoBehaviour {
    public GameObject measure1;

    // Use this for initialization
    void Start () {
        Debug.Log("The 1st result: " + GameData.result1);

        measure1.GetComponent<RectTransform>().sizeDelta = new Vector2(100, (378* GameData.result1)/100);
        if(GameData.result1 < 50)
        {
            measure1.GetComponent<Image>().color = Color.red;
        }
        else if(50 <= GameData.result1 && GameData.result1 < 80)
        {
            measure1.GetComponent<Image>().color = Color.yellow;

        }

        else if (GameData.result1>=80)
        {

            measure1.GetComponent<Image>().color = Color.green;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
