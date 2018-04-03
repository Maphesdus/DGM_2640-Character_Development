using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Movement : MonoBehaviour {
	Animator anim;

	int attackStateHash = Animator.StringToHash("Base Layer.Attack");
	int idleStateHash = Animator.StringToHash("Base Layer.Idle");
	int walkStateHash = Animator.StringToHash("Base Layer.Walk");

	int LayerIndex = 0;

	// START:
	void Start () {
		anim = GetComponent<Animator>();
	} // END Start


	// UPDATE:
	void Update () {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);


		float move = Input.GetAxis("Vertical");
		anim.SetFloat("Speed", move);

		// Find out what state the animator is currently in:
		AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(LayerIndex);


		// Previously we used "stateInfo.nameHash", but that parameter is obsolete in
		// newer versions of Unity, so now we use "stateInfo.fullPathHash" instead.
		if (Input.GetKeyDown(KeyCode.Space)) {
			//anim.SetTrigger (attackStateHash);
			//anim.SetTrigger("Base Layer.Attack");
			anim.SetBool("Jump", true);
		}
		else
			anim.SetBool("Jump", false);
			//float attack = Input.GetAxis("Fire1");
			//anim.SetBool("Attack", attack);
	} // END Update
} // END Movement