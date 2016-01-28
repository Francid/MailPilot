﻿using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {


	//PRIVATE INSTANCE VARIABLE
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _verticalSpeed;
	private float _horizontalDrift;

	//PUBLIC VARIABLES
	public float minVerticalSpeed = 5f;
	public float maxVerticalSpeed = 10f;
	public float minHorizontalSpeed = -2f;
	public float maxHorizontalSpeed = 2f;

	// Use this for initialization
	void Start () {
		//Make refrence with the Transform component
		this._transform = gameObject.GetComponent<Transform> ();

		//Reset the Island Sprite to the Top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this.transform.position;
		this._currentPosition -= new Vector2(this._horizontalDrift, this._verticalSpeed);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.y <= -330) {
			this.Reset ();
		}
	}

	public void Reset(){
		this._verticalSpeed = Random.Range (this.minVerticalSpeed, this.maxVerticalSpeed);
		this._horizontalDrift = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		float xPosition = Random.Range (-206f, 206f);
		this._transform.position = new Vector2 (xPosition, 330f);
	}
}
