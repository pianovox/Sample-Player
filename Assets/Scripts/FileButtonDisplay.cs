using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FileButtonDisplay : MonoBehaviour
{

	public int fileButtonID;
	public Text fileLabel;


	void Start ()
	{
		DisplayFileButton ();
		print (ButtonController.BankID);
//		DimEmptyButtons ();
	}


	public Text DisplayFileButton ()
	{
		fileLabel.text = "" + (1000 + (ButtonController.BankID * 10) + fileButtonID + 1); 
		return fileLabel;
	}

	public void DimEmptyButtons ()
	{

		// change color or otherwise indicate if button clip is null
	}



}
