using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BankButtons : MonoBehaviour
{

	public static int BankID = 0;
	public BankDisplay bankInfo;

	void Start ()
	{

	}

	public void BankUp ()
	{
		BankID += 1;
		UpdateAllValues ();

		print (BankID);
	}
	
	public void BankDown ()
	{
		BankID -= 1;
		UpdateAllValues ();

		print (BankID);
	}
	
	public void BankUpX10 ()
	{
		BankID += 10;
		UpdateAllValues ();

		print (BankID);
	}
	
	public void BankDownX10 ()
	{
		BankID -= 10;
		UpdateAllValues ();

		print (BankID);
	}

	public void UpdateAllValues ()
	{
		// bang values to display new bank and file info

		GameObject.Find ("bankDisplayer").GetComponent<BankDisplay> ().DisplayBank ();
	}
}
