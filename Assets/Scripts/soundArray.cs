using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class soundArray : MonoBehaviour
{
	public static AudioClip[] list;
	public AudioClip clip;
	public int ButtonID;
	public static int BankID = 0;


	string audioPath;
	//	HELP! Trying to connect to the inspector so I can use isInteractable or 
	//	change color if it's disabled
	//	public Button myButton; 
	
	void Start ()
	{		
		if (clip == null) {

			//	HELP! I know I'm reusing this line over and over. 
			//	I can't initialize it up top because of ButtonID

			audioPath = "Audio/" + (1000 + (BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
			print (audioPath);
		}
	}
	
	public void Click () {
		if (clip == null) {
			audioPath = "Audio/" + (1000 + (BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
			print (audioPath);

//			if (!myButton.IsInteractable ()) {
//				Debug.Log("Button has been Disabled");
//			}

		} else {
			//	This is leftover. Disregard.
			//	if (Input.GetMouseButtonDown(0)) {

			audioPath = "Audio/" + (1000 + (BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
			AudioSource.PlayClipAtPoint (clip, new Vector3 (5, 1, 2));
			print (ButtonID);	
		}
	}

	public void BankUp (){
		BankID += 1;
		print (BankID);
	}

	public void BankDown (){
		BankID -= 1;
		print (BankID);
	}

	public void BankUpX10 (){
		BankID += 10;
		print (BankID);
	}
	
	public void BankDownX10 (){
		BankID -= 10;
		print (BankID);
	}
}
