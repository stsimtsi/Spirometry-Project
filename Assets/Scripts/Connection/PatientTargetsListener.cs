using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PatientTargetsListener : AndroidJavaProxy
{
    public PatientTargetsListener() : base("com.example.mysdk.PatientTargetsListener")
    {

    }

    public void listen(double targetFevValue, double targetPefValue)
    {
        Debug.Log("----> Patient's Fev1 Target Value ----> " + targetFevValue);
        Debug.Log("----> Patient's PEF Target Value ----> " + targetPefValue);
        GameData.tartgetValueSpirometer = targetPefValue;
        Debug.Log("!!!!!!!!!!!!!!!!!!!!TARGET PEF FROM SPIROMETER !!!!!!!!!!!!!!!!!!! " + GameData.tartgetValueSpirometer);

    }
}