﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public Transform player;		//target for the camera to follow
	public float xOffset;			//how much x-axis space should be between the camera and target

	void start(){
		GameObject pig_player = GameObject.FindGameObjectWithTag("Player");
		if (pig_player == null) {
			Debug.LogError("Cannot find piggie sprite");
			return;
		}
		player = pig_player.transform;
		xOffset = transform.position.x - player.position.x;
	}
	void Update()
	{
		//follow the target on the x-axis only
		if (player != null) {

		transform.position = new Vector3 (player.position.x + xOffset, transform.position.y, transform.position.z);

		}
	}
}
