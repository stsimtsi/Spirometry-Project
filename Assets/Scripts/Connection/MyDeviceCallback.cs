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


public class MyDeviceCallback : AndroidJavaProxy
{
    // TODO: replace with full Java name for LoginListener interface
    public MyDeviceCallback() : base("com.example.mysdk.MyDeviceCallback")
     {

    }

 
    public void listenFlowUpdated(float predictedPercentageOfTarget, float actualPercentageOfTarget)
    {
        //Debug.Log("FLOW UPDATED");
        //Debug.Log("---> predictedPercentageOfTarget: " + predictedPercentageOfTarget);
        //GameObject.Find("PredictedMeasurement").GetComponent<Text>().text = predictedPercentageOfTarget.ToString();

        GameData.predictedPercentageOfTarget = predictedPercentageOfTarget;



        //Debug.Log("---> actualPercentageOfTarget: " + actualPercentageOfTarget);
        // GameObject.Find("ActualMeasurement").GetComponent<Text>().text = actualPercentageOfTarget.ToString();

        GameData.actualPercentageOfTarget = actualPercentageOfTarget;
        //Debug.Log("*******************");
        if(GameData.spirometrisesNumber==1)
        {
            GameData.result1 = predictedPercentageOfTarget;
            Debug.Log("********** I take the result of the 1st TEST *********** :" + GameData.result1);
        }

        else if (GameData.spirometrisesNumber == 2)
        {
            GameData.result2 = predictedPercentageOfTarget;
            Debug.Log("********** I take the result of the 2nd TEST *********** :" + GameData.result2);
        }

        else if (GameData.spirometrisesNumber == 3)
        {
            GameData.result3 = predictedPercentageOfTarget;
            Debug.Log("********** I take the result of the 3rd TEST *********** :" + GameData.result3);
        }

    }
    public void listenResultsUpdated(int pefValue, int fevValue, int qualityRawCode, int qualityMsgCode)
    {
        GameData.fevValue = fevValue;
        GameData.pefValue = pefValue;
        GameData.qualityRawCode = qualityRawCode;
        GameData.qualityMsgCode = qualityMsgCode;

        if (GameData.qualityMsgCode == 0)
            GameData.messageResultString = "Μην διστάζετε";

        else if (GameData.qualityMsgCode == 1)
            GameData.messageResultString = "Φυσήξτε πιο δυνατα";

        else if (GameData.qualityMsgCode == 2)
            GameData.messageResultString = "Μην ξεκινάτε τόσο νωρίς";

        else if (GameData.qualityMsgCode == 3)
            GameData.messageResultString = "Αποφύγετε το βήχα";

        else if (GameData.qualityMsgCode == 4)
            GameData.messageResultString = "Δυνατό Φύσημα ";

        else if (GameData.qualityMsgCode == 5)
            GameData.messageResultString = "Καλή μέτρηση";




       


    }

}
