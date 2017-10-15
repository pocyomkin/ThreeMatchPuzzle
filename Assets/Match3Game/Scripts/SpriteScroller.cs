﻿using UnityEngine;
using System.Collections;

public class SpriteScroller : MonoBehaviour {
	public Vector3 speed = new Vector3(-0.1f, 0f, 0f);

	void Start () {
		GetComponent<Rigidbody>().velocity = speed;
	}
	
	void Update () {
		if (transform.localPosition.x<-4000f) transform.localPosition = Vector3.zero;
	}
}
