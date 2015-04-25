using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BankDisplay : MonoBehaviour {

	public Text bankDisplay;
	public static string currentBank;


	void Start () 
	{

	}
	
	public string DisplayBank ()
	{
		string lowBank = "" + (1000 + (BankButtons.BankID * 10) + 1);
		string highBank = "" + (1000 + (BankButtons.BankID * 10) + 10);	
		currentBank	= "Bank: " + BankButtons.BankID + "\n" + lowBank + " - " + highBank;
		return currentBank;
	}



}
