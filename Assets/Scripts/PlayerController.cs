﻿using UnityEngine;
using System.Collections;



public class PlayerController : MonoBehaviour {

	public float speed;
	public float xMin, xMax, yMin, yMax;

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		GetComponent<Rigidbody2D>().velocity = movement*speed;

		GetComponent<Rigidbody2D>().position = new Vector2
		(
				Mathf.Clamp (GetComponent<Rigidbody2D>().position.x, xMin, xMax),
				Mathf.Clamp (GetComponent<Rigidbody2D>().position.y, yMin, yMax)
		);
	}
}