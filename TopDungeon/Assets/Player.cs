﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private BoxCollider2D boxCollider;

	private Vector3 moveDelta;

	// Use this for initialization
	private void Start () {
		boxCollider = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	// void Update () {
		
	// }

	private void FixedUpdate(){
		// Reset MoveDelta
		float x = Input.GetAxisRaw("Horizontal");
		float y = Input.GetAxisRaw("Vertical");
		moveDelta = new Vector3(x, y, 0);

		// Swap the sprite direction when moving right or left
		if (moveDelta.x > 0){
			transform.localScale = Vector3.one;
		} 
		else if (moveDelta.x < 0){
			transform.localScale = new Vector3(-1, 1, 1);
		}

		// Move the character move
		transform.Translate(moveDelta * Time.deltaTime);
	}
}
