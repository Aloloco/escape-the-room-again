using UnityEngine;
using System.Collections;

public class ExitDoor : MonoBehaviour {

	private Animator anim;
	private AudioSource openSound;
	private AudioSource closeSound;

	public float doorDelay = 0.5f;

	public bool opened;

	// Use this for initialization
	void Start () {
		this.opened = false;
		Debug.Log ("I'm a door, i'm " + opened + "");
		anim = this.GetComponent<Animator>();
		openSound = transform.FindChild ("door open sound").GetComponent<AudioSource> ();
		closeSound = transform.FindChild ("door close sound").GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("open", this.opened);
	}

	public void Toggle () {
		if (!this.opened) {
			StartCoroutine(Open());
		} else {
			StartCoroutine(Close());
		}
	}
	
	public IEnumerator Open () {
		yield return new WaitForSeconds (doorDelay);
		this.opened = true;
		openSound.Play();
		Debug.Log ("open");
	}

	public IEnumerator Close () {
		closeSound.Play ();
		yield return new WaitForSeconds (doorDelay);
		this.opened = false;
		Debug.Log ("close");
	}

}
