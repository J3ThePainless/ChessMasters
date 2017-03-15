﻿using UnityEngine;
using System.Collections;

public class TargetW : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(DestroyTimeout());
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter2D(Collider2D collider) {
		if(collider.gameObject.name == "bishopW"){
			Destroy (gameObject, 0.0f);
		}
	}
	private IEnumerator DestroyTimeout()
	{
		yield return new WaitForSeconds(2);
		Destroy (gameObject, 0.0f);
	}
}
