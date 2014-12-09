using UnityEngine;
using System.Collections;

public class ExitDoor : MonoBehaviour {


	public bool opened;

	// Use this for initialization
	void Start () {
		this.opened = false;
		Debug.Log ("I'm a door, i'm " + opened + "");
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Open () {
		this.opened = true;
		Debug.Log ("open");
	}

	public void Close () {
		this.opened = false;
		Debug.Log ("close");
	}

}
