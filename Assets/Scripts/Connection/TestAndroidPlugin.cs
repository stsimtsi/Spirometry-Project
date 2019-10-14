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

public class TestAndroidPlugin : MonoBehaviour
{
    public GameObject bluetoothScanning;

    // Start the connection from the CameraMain in Game
    void Start()
    {
		Debug.Log(GameData.test);
		Debug.Log(GameData.tartgetValueSpirometer);
		GameData.test=true;
		Debug.Log(GameData.test);
		Debug.Log("spirNum"+GameData.spirometrisesNumber);
        bluetoothScanning.SetActive(true);
        Debug.Log("Androidtion is to be called"+GameData.connectedBluetooth);

        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject context = jc.GetStatic<AndroidJavaObject>("currentActivity");

        //create java instance and pass callback
        var ajc = new AndroidJavaClass("com.example.mysdk.Unity");
        ajc.CallStatic("initialize", context, new MyDeviceCallback(), new DeviceFoundListener(), new DeviceConnectedListener(), new ConnectionLostListener(), new PatientTargetsListener());

        // ajc.CallStatic("scan");
        Debug.Log("===================== " + GameData.connectedBluetooth + " ========================");
        //Debug.Log("===================== " + GameData1.executingScan + " ========================");
	

    }


    

   

    // Update is called once per frame
    void Update()
    {

	AudioListener.volume=PlayerPrefs.GetFloat("listener");
       
       

        if (!GameData.connectedBluetooth && !GameData.executingScan)
        {
            Debug.Log("I test if lost the connection");
            GameData.executingScan = true;
            //scan and print found devices
            Debug.Log("Start scan");
            var ajc = new AndroidJavaClass("com.example.mysdk.Unity");
            ajc.CallStatic("scan");
        }
            


    }
}
