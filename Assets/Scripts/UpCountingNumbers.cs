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

public class UpCountingNumbers : MonoBehaviour {

    public GameObject imageCounting;
    public Sprite counting1;
    public Sprite counting2;
    public Sprite counting3;
    public GameObject waitScreen;
    public AudioClip[] auClipNumbers;
	public AudioSource one;
	public AudioSource two;
	public AudioSource three;


    void Awake()
    {
        

    }

    // Use this for initialization
    void Start () {
       
		
	}
	
	// Update is called once per frame
	void Update () {


       
        if(GameData.waitScreenOff)
        {
            
            imageCounting.GetComponent<Image>().sprite = counting1;
            StartCoroutine(Countdown());
            GameData.waitScreenOff = false;
        }
		
	}


    IEnumerator Countdown()
    {
		//one.enabled=!one.enabled;
		//two.enabled=!two.enabled;
		//three.enabled=!three.enabled;
      
        imageCounting.GetComponent<Image>().sprite = counting1;
		one.Play();
        yield return new WaitForSeconds(1);
		
        imageCounting.GetComponent<Image>().sprite = counting2;
		two.Play();
        yield return new WaitForSeconds(1);
		
        imageCounting.GetComponent<Image>().sprite = counting3;
		three.Play();
        yield return new WaitForSeconds(1);
        transform.parent.transform.GetChild(1).GetComponent<Animator>().SetBool("finishCounting", false);
        waitScreen.SetActive(false);
        imageCounting.GetComponent<Image>().sprite = counting1;
        GameData.highMeasurementSTart = true;

        GameData.openSceenGame = true;
       




    }
}
