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

public class AnimationGame : MonoBehaviour
{

        public GameObject clouds;
        public GameObject counting;
        public GameObject countingResultScene;
        public GameObject countingResultSceneWrong;

    void Awake()
    {
        GameData.openSceenGame = false;

    }

    // Use this for initialization
    void Start()
    {
        counting.GetComponent<Animator>().SetBool("startCounting", true);
        
        clouds.GetComponent<Animator>().SetBool("moveCloudStart", true);


    }

    // Update is called once per frame
    void Update()
    {
        if(GameData.openResultScene)
        {
           
            countingResultScene.GetComponent<Animator>().SetBool("startCounting", true);
            GameData.openResultScene = false;
        }


       else if (GameData.openResultSceneWrong)
        {

            countingResultSceneWrong.GetComponent<Animator>().SetBool("startCounting", true);
            GameData.openResultSceneWrong = false;
        }

    }
}
