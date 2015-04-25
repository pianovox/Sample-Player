using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FileButton : MonoBehaviour
{
	
	public int ButtonID;
	public Text fileButtonText;
	public static string audioPath;
	public AudioClip clip;
	AudioSource aSource;
	
	void Start ()
	{	
		if (clip == null) {
			audioPath = "Audio/" + (1000 + (BankButtons.BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
			print (audioPath);
		}
	}

	public void Click ()
	{
		if (clip == null) {
			audioPath = "Audio/" + (1000 + (BankButtons.BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
			print (audioPath);
				
		} else {
				
			audioPath = "Audio/" + (1000 + (BankButtons.BankID * 10) + ButtonID + 1);
			clip = (AudioClip)Resources.Load (audioPath); 
			print (ButtonID);				
			PlayClipAt (clip, transform.position);
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
	
	
}