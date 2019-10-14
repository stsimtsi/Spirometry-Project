using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartVariablesNextTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void RestartVariables()
    {
        GameData.spirometrisesNumber++;
        GameData.livesCharacter++;
        GameData.predictedPercentageOfTarget = 0.0f;
        GameData.actualPercentageOfTarget = 0.0f;
        GameData.maxCharacterY = 0.0f;
        GameData.fevValue = 0;
        GameData.pefValue = 0;
        GameData.changeTree = true;
		GameData.testStarted=false;
    }
}
