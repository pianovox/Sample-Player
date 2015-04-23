using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class soundArray : MonoBehaviour
{
	public static AudioClip[] list;
	public AudioClip clip;
	public int ButtonID;
	public static int BankID = 60;
//	public Button myButton;
	
	void Start ()
	{		
		if (clip == null) {
			string file = "Audio/" + (1000 + BankID + ButtonID + 1);
			clip = (AudioClip)Resources.Load (file); 
			print (file);
		}
	}

	public void Click ()
	{
		if (clip == null) {
			string file = "Audio/" + (1000 + BankID + ButtonID + 1);
			clip = (AudioClip)Resources.Load (file); 
			print (file);

//			if (!myButton.IsInteractable ()) 
//			{
//				Debug.Log("Start Button has been Disabled");
//			}

		} else {
			//if (Input.GetMouseButtonDown(0)) {
			AudioSource.PlayClipAtPoint (clip, new Vector3 (5, 1, 2));
			print (ButtonID);	
		}
	}

	public void BankUp ()
	{
		BankID += 10;
		print (BankID);
	}

	public void BankDown ()
	{
		BankID -= 10;
		print (BankID);
	}
}
