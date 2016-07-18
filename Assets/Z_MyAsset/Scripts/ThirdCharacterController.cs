using UnityEngine;
using System.Collections;

public class ThirdCharacterController : MonoBehaviour {

	Animator _anim;
	int _hashSpeed;
	

	// Use this for initialization
	void Start () {
		_anim = GetComponent<Animator>();
		_hashSpeed = Animator.StringToHash("Speed");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)){
			_anim.SetFloat("Speed", 0.2f);
		}
	}
}
