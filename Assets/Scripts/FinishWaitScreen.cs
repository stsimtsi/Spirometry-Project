using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishWaitScreen : MonoBehaviour {
    public GameObject imageCounting;

	// Use this for initialization
	void Start () {
        GameData.openSceenGame = false;

    }
	
	// Update is called once per frame
	void Update () {
       

    }

    public void FinishCounting()
    {
        GameData.waitScreenOff = true;
        imageCounting.SetActive(true);
        
       


    }
}
