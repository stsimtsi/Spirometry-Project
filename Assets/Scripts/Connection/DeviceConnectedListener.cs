using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DeviceConnectedListener : AndroidJavaProxy
{
    public DeviceConnectedListener() : base("com.example.mysdk.DeviceConnectedListener")
     {

    }

    public void listen(string deviceName)
    {
        Debug.Log("----> CONNECTED FROM LISTENER + DeviceName: "+ deviceName);
        GameData.connectedBluetooth = true;
        GameData.executingScan = false;
    }
}
