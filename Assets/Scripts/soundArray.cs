using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class soundArray : MonoBehaviour
{
	public static AudioClip[] list;
	public AudioClip clip;
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
		bankNumberText.text = "" + (1000 + (BankID * 10) + 1) + " -" + (1000 + (BankID * 10) + 10);
		buttonText.text = "" + (1000 + (BankID * 10) + ButtonID);
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
			AudioSource.PlayClipAtPoint (clip, new Vector3 (5, 1, 2));
			print (ButtonID);	
		}
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
