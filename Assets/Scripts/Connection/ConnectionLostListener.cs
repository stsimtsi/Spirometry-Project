using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class ConnectionLostListener : AndroidJavaProxy
{

    public ConnectionLostListener() : base("com.example.mysdk.ConnectionLostListener")
     {

    }

    public void listen(string deviceName)
    {
        Debug.Log("---->THE CONNECTION LOSTED FROM LISTENER + DeviceName: " + deviceName);
        GameData.connectedBluetooth = false;
    }
}
