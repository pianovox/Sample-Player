using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FileButton : MonoBehaviour
{
	public int ButtonID;
	public static string audioPath;
	public AudioClip clip;
	AudioSource aSource;

	public int ButtonNumber;
	
	void Start ()
	{	
		if (clip == null) {
			audioPath = "Audio/" + (1000 + (ButtonController.BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
//			print (audioPath);
		}
	}
	
	void Update ()
	{
		
		if (Input.GetKeyDown (KeyCode.Q)) {
			ButtonNumber = 1;
			PlayMe ();
			print ("you pressed Q");
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			ButtonNumber = 2;
			PlayMe ();
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			ButtonNumber = 3;
			PlayMe ();
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			ButtonNumber = 4;
			PlayMe ();
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			ButtonNumber = 5;
			PlayMe ();
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			ButtonNumber = 6;
			PlayMe ();
		}
		if (Input.GetKeyDown (KeyCode.Z)) {
			ButtonNumber = 7;
			PlayMe ();
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			ButtonNumber = 8;
			PlayMe ();
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			ButtonNumber = 9;
			PlayMe ();
		}
		if (Input.GetKeyDown (KeyCode.V)) {
			ButtonNumber = 10;
			PlayMe ();
		}
	
		
	}


	public void Click ()
	{
		if (clip == null) {
			audioPath = "Audio/" + (1000 + (ButtonController.BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
			print (audioPath);				
		} else {
			audioPath = "Audio/" + (1000 + (ButtonController.BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
			print (ButtonID);				
			PlayClipAt (clip, transform.position);
		}
	}	

	AudioSource PlayClipAt (AudioClip clip, Vector3 pos)
	{
		GameObject tempGO = new GameObject ("TempAudio"); 			// create the temp object
		tempGO.transform.position = pos;			 				// set its position
		aSource = tempGO.AddComponent<AudioSource> ();	// add an audio source
		aSource.clip = clip; 	 									// define the clip
		
		// set other aSource properties here, if desired
		//================================================
		aSource.Play (); 											// start the sound
		Destroy (tempGO, clip.length); 								// destroy object after clip duration
		return aSource; 											// return the AudioSource reference
	}

	public void PlayMe ()
	{
		audioPath = "Audio/" + (1000 + (ButtonController.BankID * 10) + ButtonNumber);
		clip = (AudioClip)Resources.Load (audioPath); 
		PlayClipAt (clip, transform.position);
	}


}