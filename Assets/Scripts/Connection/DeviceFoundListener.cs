using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DeviceFoundListener : AndroidJavaProxy
{
    public DeviceFoundListener() : base("com.example.mysdk.DeviceFoundListener")
     {

    }

    public void listen(string deviceName)
    {



        Debug.Log("----> DEVICE FOUND: " + deviceName);
        Debug.Log("----> Try to connect");
        var ajc = new AndroidJavaClass("com.example.mysdk.Unity");
        ajc.CallStatic("createConnection");

        Thread.Sleep(5000);
        Debug.Log("----> Connected");

       // Debug.Log("----> STARTING TEST");
       // if (GameData.startTest)
       // {
           // ajc.CallStatic("begin");

            //Thread.Sleep(30000);
       // }
    }
}
