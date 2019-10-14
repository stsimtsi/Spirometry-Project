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

public class Bar3 : MonoBehaviour {

    public GameObject measure3;

    // Use this for initialization
    void Start()
    {
        Debug.Log("The 3rd result: " + GameData.result3);

        measure3.GetComponent<RectTransform>().sizeDelta = new Vector2(100, (378 * GameData.result3) / 100);
        if (GameData.result3 < 50)
        {
            measure3.GetComponent<Image>().color = Color.red;
        }
        else if (50 <= GameData.result3 && GameData.result3 < 80)
        {
            measure3.GetComponent<Image>().color = Color.yellow;

        }

        else if (GameData.result3 >= 80)
        {

            measure3.GetComponent<Image>().color = Color.green;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
