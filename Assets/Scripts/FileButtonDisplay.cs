using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FileButtonDisplay : MonoBehaviour
{
	public int fileNumber;
	public int fileButtonID;
	public Text fileLabel;

	void Start()
	{
		DisplayFileButton ();
		DimEmptyButtons ();
	}

	public Text DisplayFileButton()
	{
		fileNumber = fileButtonID ;
		fileLabel.text = "" + (1000 + (BankButtons.BankID * 15) + fileButtonID + 1); 
		return fileLabel;
	}

	public void DimEmptyButtons() {

		// change color or otherwise indicate if button clip is null
	}

	
}
