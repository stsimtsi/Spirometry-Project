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

public class Bar2 : MonoBehaviour {
    public GameObject measure2;

    // Use this for initialization
    void Start()
    {
        Debug.Log("The 2nd result: " + GameData.result2);

        measure2.GetComponent<RectTransform>().sizeDelta = new Vector2(100, (378 * GameData.result2) / 100);
        if (GameData.result2 < 50)
        {
            measure2.GetComponent<Image>().color = Color.red;
        }
        else if (50 <= GameData.result2 && GameData.result2 < 80)
        {
            measure2.GetComponent<Image>().color = Color.yellow;

        }

        else if (GameData.result2 >= 80)
        {

            measure2.GetComponent<Image>().color = Color.green;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
