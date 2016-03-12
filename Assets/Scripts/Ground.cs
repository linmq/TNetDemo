using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	// Use this for initialization
	void OnClick () 
	{
		GamePlayer.instance.target = TouchHandler.worldPos;
		Debug.Log ("click world pos: " + TouchHandler.worldPos);
	}
}
