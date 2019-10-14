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

public static class GameData
{

    private static readonly String FILE_PATH_UserInformation;

    public static bool hitWall
    {
        get;
        set;
    }

    public static bool bluetoothRun
    {
        get;
        set;
    }

    public static bool hitWallFinish
    {
        get;
        set;
    }


    public static bool startMoving
    {
        get;
        set;
    }

    public static int livesCharacter
    {
        get;
        set;
    }

    public static bool waitScreenOff
    {
        get;
        set;
    }

    public static bool openSceenGame
    {
        get;
        set;
    }

    public static bool startJump
    {
        get;
        set;
    }

    //true when the jump is correct and false if the jump is incoreect
    public static bool finishStatus
    {
        get;
        set;
    }

    public static bool openResultScene
    {
        get;
        set;
    }

    public static bool openResultSceneWrong
    {
        get;
        set;
    }

    public static bool character1Lives
    {
        get;
        set;
    }

    public static bool character2Lives
    {
        get;
        set;
    }

    public static bool character3Lives
    {
        get;
        set;
    }

    public static bool highMeasurementSTart
    {
        get;
        set;
    }


    public static string namePlayer
    {
        get;
        set;
    }

    public static string lastnamePlayer
    {
        get;
        set;
    }
    public static int agePlayer
    {
        get;
        set;
    }

    public static int weightPlayer
    {
        get;
        set;
    }

    public static int heightPlayer
    {
        get;
        set;
    }

    public static DateTime birthdayPlayer
    {
        get;
        set;
    }


    public static string birthdayDay
    {
        get;
        set;
    }

    public static string birthdayMonth
    {
        get;
        set;
    }

    public static string birthdayYear
    {
        get;
        set;
    }

    public static string genderPlayer
    {
        get;
        set;
    }

    public static bool connectedBluetooth
    {
        get;
        set;
    }

    public static bool executingScan
    {
        get;
        set;
    }

    public static float predictedPercentageOfTarget
    {
        get;
        set;
    }

    public static float actualPercentageOfTarget
    {
        get;
        set;
    }

    public static int fevValue
    {
        get;
        set;
    }

    public static int pefValue
    {
        get;
        set;
    }

    public static int qualityRawCode
    {
        get;
        set;
    }
    public static int qualityMsgCode
    {
        get;
        set;
    }

    public static bool startTest
    {
        get;
        set;
    }

    public static bool startConnection
    {
        get;
        set;
    }


    public static bool changeTree
    {
        get;
        set;
    }

    public static double tartgetValueSpirometer
    {
        get;
        set;
    }

    public static float distanceCharacter
    {
        get;
        set;
    }

    public static float velocityCharacter
    {
        get;
        set;
    }

    public static float heightTree
    {
        get;
        set;
    }

    public static float changeYTree
    {
        get;
        set;
    }

    public static int spirometrisesNumber
    {
        get;
        set;
    }

    public static float result1
    {
        get;
        set;

    }
    public static float result2
    {
        get;
        set;

    }
    public static float result3
    {
        get;
        set;

    }

    public static string ethnicityString
    {
        get;
        set;

    }
    public static string genderString
    {
        get;
        set;

    }

    public static float maxCharacterY
    {
        get;
        set;

    }

    public static float result1PEF
    {
        get;
        set;

    }

    public static float result1FEV
    {
        get;
        set;

    }


    public static float result2PEF
    {
        get;
        set;

    }

    public static float result2FEV
    {
        get;
        set;

    }

    public static float result3PEF
    {
        get;
        set;

    }

    public static float result3FEV
    {
        get;
        set;

    }

    public static string messageResultString
    {
        get;
        set;

    }

    public static bool endExplosion
    {
        get;
        set;

    }


    public static bool startExplosion
    {
        get;
        set;

    }
	 public static bool test
    {
        get;
        set;

    }
	public static bool testStarted
	{
		get;
		set;
	}
	public static string allResultsText{
		
		get;
		set;
		
	}




    static GameData()
    {
		GameData.allResultsText="";
		testStarted=false;
		test=false;
        startExplosion = false;
        endExplosion = false;
        messageResultString = "";
        result1PEF = 0.0f;
        result1FEV = 0.0f;

        result2PEF = 0.0f;
        result2FEV = 0.0f;

        result3PEF = 0.0f;
        result3FEV = 0.0f;


        maxCharacterY = 0.0f;
        genderString ="";
        ethnicityString = "";
        spirometrisesNumber = 0;
        result1 = 0.0f;
        result2 = 0.0f;
        result3 = 0.0f;
        changeYTree = 0.0f;
        heightTree = 0.0f;
        velocityCharacter = 0.0f;
        distanceCharacter = 0.0f;
        changeTree = true;
        tartgetValueSpirometer = 0.0f;
        startConnection = false;
        startTest = false;
        qualityRawCode = 0;
        qualityMsgCode = 0;
        fevValue = 0;
        pefValue = 0;
        qualityRawCode = 0;
        bluetoothRun = false;
        executingScan = false;
        birthdayDay = "";
        birthdayMonth = "";
        birthdayYear = "";

        predictedPercentageOfTarget = 0.0f;
        actualPercentageOfTarget = 0.0f;
        connectedBluetooth = false;
        genderPlayer = "";

        namePlayer = "";
        lastnamePlayer = "";
        agePlayer = 0;
        weightPlayer = 0;
        heightPlayer = 0;
        highMeasurementSTart = false;
        hitWallFinish = false;
        hitWall = false;
        character1Lives = false;
        character2Lives = false;
        character3Lives = false;
        openResultScene = false;
        openResultSceneWrong = false;
        finishStatus = false;
        startJump = false;
        livesCharacter = 0;
        startMoving = false;
        waitScreenOff = false;
        openSceenGame = false;


        GameData.namePlayer = "";
#if (UNITY_EDITOR || UNITY_STANDALONE_WIN)
        FILE_PATH_UserInformation = "saveUserInformation.txt";
#elif (UNITY_ANDROID)
			        FILE_PATH_UserInformation = Application.persistentDataPath + "/saveUserInformation";
#endif

        //GameData.LoadUserInformation();


    }


    public static void LoadUserInformation()
    {




        if (!File.Exists(FILE_PATH_UserInformation))
        {
            return;
        }
        try
        {
            StreamReader source = new StreamReader(FILE_PATH_UserInformation, Encoding.UTF8);

            String content = source.ReadToEnd();
			GameData.allResultsText=content;
           // string[] tokens = content.Split('\n');

           // GameData.namePlayer = tokens[0];
            //Debug.Log("ekana load to arxeio ths Language "+GameData.Language);

            source.Close();
        }

        catch (Exception e)
        {
            Debug.Log(e.Message);
        }


    }


    public static void SaveUserInformation()
    {


        Debug.Log("============I save the User file==============");
        StreamWriter target = new StreamWriter(FILE_PATH_UserInformation, true, Encoding.UTF8);

        target.WriteLine("Όνομα: "+GameData.namePlayer);
        target.WriteLine("Επίθετο: "+ GameData.lastnamePlayer);
        target.WriteLine("Ημερομηνία Γέννησης: " + Patient.birthday);
        target.WriteLine("Ύψος: " + Patient.height);
        target.WriteLine("Βάρος: " + Patient.weight);
        target.WriteLine("Φύλλο: " + GameData.genderString);
        target.WriteLine("Εθνικότητα: " + GameData.ethnicityString);
        target.WriteLine("L/m Target Value: " + GameData.tartgetValueSpirometer);
        target.WriteLine("1η Σπιρομέτρηση (Predicted Percentage Of Target): " + GameData.result1);
        target.WriteLine("1η Σπιρομέτρηση (FEV): " + GameData.result1FEV);
        target.WriteLine("1η Σπιρομέτρηση (PEF): " + GameData.result1PEF);
        target.WriteLine("2η Σπιρομέτρηση (Predicted Percentage Of Target): " + GameData.result2);
        target.WriteLine("2η Σπιρομέτρηση (FEV): " + GameData.result2FEV);
        target.WriteLine("2η Σπιρομέτρηση (PEF): " + GameData.result2PEF);
        target.WriteLine("3η Σπιρομέτρηση (Predicted Percentage Of Target): " + GameData.result3);
        target.WriteLine("3η Σπιρομέτρηση (FEV): " + GameData.result3FEV);
        target.WriteLine("3η Σπιρομέτρηση (PEF): " + GameData.result3PEF);
        target.WriteLine("\n");
        target.WriteLine("==============================================================");
        target.WriteLine("\n");




        target.Close();
    }



}//close class
