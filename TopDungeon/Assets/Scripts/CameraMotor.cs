using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour {

	// lookAt the obj
	public Transform lookAt;

	public float boundX = 0.15f;
	public float boundY = 0.05f;

	private void LateUpdate(){
		Vector3 delta = Vector3.zero;
	}
}
