using UnityEngine;
using System.Collections;

public class PanicButon : MonoBehaviour {

	private GameObject TurnMeOff;
	
	public void Panic()
	{
		TurnMeOff = GameObject.Find ("TempAudio");
		Destroy (TurnMeOff);

	}

}
