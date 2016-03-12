using UnityEngine;
using System.Collections;

public class GamePlayer : MonoBehaviour {

	public static GamePlayer instance;
	// Use this for initialization
	void Awake () {
		if (TNManager.isThisMyObject) {
			instance = this;
		}
	}

	public Vector3 target;
	public float speed = 5f;
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position, target, Time.deltaTime*speed);
	}
}
