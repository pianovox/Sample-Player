using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FileButtonDisplay : MonoBehaviour
{
	public int fileNumber;
	public Text fileLabel;

	public Text DisplayFileButton()
	{
		fileNumber = GameObject.Find ("FileButtons").GetComponent<FileButton>().ButtonID ;
		fileLabel.text = "" +fileNumber;
		return fileLabel;
	}


	
}
