using UnityEngine;
using System.Collections;

public class RoomStatus : MonoBehaviour {

	private DoorButton button;
	private ExitDoor door;

	void Awake() {

		button = GameObject.FindGameObjectWithTag (Tags.button).GetComponent<DoorButton>();
		door = GameObject.FindGameObjectWithTag (Tags.door).GetComponent<ExitDoor>();

	}

	void Update() {
		ButtonPressed ();
	}
	
	void ButtonPressed() {
		if (button.pressed) {
			door.Open ();
		} 
	}



}
