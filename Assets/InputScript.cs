using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputScript : MonoBehaviour {

	public InputField nameF;
	public InputField lastNameF;
	public InputField heightF;
	public InputField weightF;
	public string myName;
	public string myLast;
	public int myHeight;
	public int myWeight;
	
	
	public void MyFunction () {
		myName=nameF.text;
		myLast=lastNameF.text;
		myHeight=int.Parse(heightF.text);
		myWeight=int.Parse(weightF.text);
		
		if (myName == "Σοφία")
{
Debug.Log("Correct! The word " + myName + " cityi is correct! Ok");
}
else
{
Debug.Log("Incorrect! The answer was " + myName + " Ok");
}
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
GameData.spirometrisesNumber=1;
GameData.livesCharacter=0;
GameData.result1=0.0f;
GameData.result2=0.0f;
GameData.result3=0.0f;
GameData.result1FEV=0.0f;
GameData.result1PEF=0.0f;
GameData.result2FEV=0.0f;
GameData.result2PEF=0.0f;
GameData.result3FEV=0.0f;
GameData.result3PEF=0.0f;
	}
	
	
	
	
}
