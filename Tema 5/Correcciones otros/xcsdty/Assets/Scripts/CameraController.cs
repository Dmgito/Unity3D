using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		AnimatorStateInfo currentBaseState = anim.GetCurrentAnimatorStateInfo(0);
		if (currentBaseState.IsName("Idle")  && Input.GetKeyDown (KeyCode.J)) {
			anim.SetTrigger ("shootCamera");
		}
	}
}
