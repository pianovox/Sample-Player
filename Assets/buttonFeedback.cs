using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class buttonFeedback : MonoBehaviour {
	public Color buttonColor;
	Color disabledColor = Color.red;
	public Button button;
	public Text buttonText;
	public int uniqueButtonID;


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		SetButtonText();
	}

	void SetButtonText()
	{
		buttonText.text = "" + (1000 + (soundArray.BankID*10) + uniqueButtonID + 1);
		if (File.Exists("Audio/1001.aif") == true){
			print ("I found the file");
//			button.colors.normalColor = disabledColor;
		}
	}
}
