using UnityEngine;
using System.Collections;

public class DoorButton : MonoBehaviour {

	public ExitDoor door;
	public float buttonOperationDistance = 10.0f;
	private AudioSource buttonBeep;

	void Start() {
		door = GameObject.FindGameObjectWithTag("Door").GetComponent<ExitDoor>();
		buttonBeep = this.GetComponent<AudioSource> ();
	}

	void Update() {
		RaycastHit hit;

		if (Input.GetKeyDown(KeyCode.E)) {
			Debug.Log ("Pressed E key");
			if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, buttonOperationDistance)) {
				Debug.Log (hit.transform.tag);
				if (hit.transform == this.transform) {
					Debug.Log ("PRESSED");
					buttonBeep.Play ();
					door.Toggle();
				}
			}
		}

	}

}
