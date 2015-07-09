using UnityEngine;
using System.Collections;

public class PanicButon : MonoBehaviour
{

	private GameObject TurnMeOff;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			Panic ();
		}
	}
	
	public void Panic ()
	{
		TurnMeOff = GameObject.Find ("TempAudio");
		Destroy (TurnMeOff);
	}
}
