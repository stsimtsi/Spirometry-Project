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

public class Rotation : MonoBehaviour {

    public GameObject imageRot;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (!GameData.connectedBluetooth)
        {
            imageRot.transform.Rotate(0, 0, -180 * Time.deltaTime, Space.World);
        }

        else if(GameData.connectedBluetooth)
        {

            imageRot.transform.Rotate(0, 0, 0);
        }
       



    }
}
