using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class soundArray : MonoBehaviour
{
	AudioClip clip;
	AudioSource aSource;
	public int ButtonID;
	public static int BankID = 0;
	public Text bankNumberText;
	public Text buttonText;
	string audioPath;
	

	void Start ()
	{	
		if (clip == null) {
			audioPath = "Audio/" + (1000 + (BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
			print (audioPath);
		}
	}

	void Update ()
	{
		string lowBank = "" + (1000 + (BankID * 10) + 1);
		string highBank = ""+ (1000 + (BankID * 10) + 10);

		bankNumberText.text = "Bank: " + BankID +"\n" + lowBank + " - " + highBank;




	}


	
	public void Click ()
	{
		if (clip == null) {
			audioPath = "Audio/" + (1000 + (BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
			print (audioPath);

		} else {

			audioPath = "Audio/" + (1000 + (BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
//			AudioSource.PlayClipAtPoint (clip, new Vector3 (5, 1, 2));
			print (ButtonID);

			PlayClipAt(clip, transform.position);
		}
	}

	AudioSource PlayClipAt(AudioClip clip, Vector3 pos)
	{
		GameObject tempGO = new GameObject("TempAudio"); 			// create the temp object
		tempGO.transform.position = pos;			 				// set its position
		aSource = tempGO.AddComponent<AudioSource>();	// add an audio source
		aSource.clip = clip; 	 									// define the clip
		
		// set other aSource properties here, if desired
		//================================================
		aSource.Play(); 											// start the sound
		Destroy(tempGO, clip.length); 								// destroy object after clip duration
		return aSource; 											// return the AudioSource reference
	
	}



	public void BankUp ()
	{
		BankID += 1;
		print (BankID);
	}

	public void BankDown ()
	{
		BankID -= 1;
		print (BankID);
	}

	public void BankUpX10 ()
	{
		BankID += 10;
		print (BankID);
	}
	
	public void BankDownX10 ()
	{
		BankID -= 10;
		print (BankID);
	}
}
