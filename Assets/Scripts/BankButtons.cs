using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BankButtons : MonoBehaviour
{
//	public static int BankID;
//	public BankDisplay bankInfo;

	void Start()
	{

	}

	public void BankUp ()
	{
		ButtonController.BankID += 1;
		UpdateAllValues ();
		print (ButtonController.BankID);
	}
	
	public void BankDown ()
	{
		ButtonController.BankID -= 1;
		UpdateAllValues ();
		print (ButtonController.BankID);
	}
	
	public void BankUpX10 ()
	{
		ButtonController.BankID += 10;
		UpdateAllValues ();
		print (ButtonController.BankID);
	}
	
	public void BankDownX10 ()
	{
		ButtonController.BankID -= 10;
		UpdateAllValues ();
		print (ButtonController.BankID);
	}

	public void UpdateAllValues ()
	{
				GameObject.Find ("bankDisplayer").GetComponent<BankDisplay> ().DisplayBank ();
				GameObject.Find ("FileButtons").GetComponent<FileButtonDisplay> ().DisplayFileButton ();
	}
}
