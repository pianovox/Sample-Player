using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BankDisplay : MonoBehaviour {

	public Text bankDisplay;
	private string currentBank;

	void Start () 
	{
		DisplayBank ();
	}
	
	public Text DisplayBank ()
	{
		string lowBank = "" + (1000 + (BankButtons.BankID * 10) + 1);
		string highBank = "" + (1000 + (BankButtons.BankID * 10) + 10);	
		currentBank	= "Bank: " + BankButtons.BankID + "\n" + lowBank + " - " + highBank;
		bankDisplay.text = currentBank;
		return bankDisplay;
	}
}
