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

public class Patient  {

    public static string birthday
    {
        get;
        set;
    }

    public static float weight
    {
        get;
        set;
    }


    public static float height
    {
        get;
        set;
    }


    

    public static int gender
    {
        get;
        set;
    }

    public static int ethnicity
    {
        get;
        set;
    }


    static Patient()
    {
        height = 0.0f;
        weight = 0.0f;
        
       
        gender = -1;
        ethnicity = 23;

        
    }



    }
