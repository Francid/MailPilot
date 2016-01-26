using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {

	// PRIVATE INSTANCE VARIABLE
	private float _playerInput;
	private Transform _transform;
	private Vector2 _currentPosition;

	//PUBLIC VARIABLES
	public float speed = 5f;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this.transform.position;

		this._playerInput = Input.GetAxis ("Horizontal");
		// if my player input is +ve move right
		if (this._playerInput > 0) {
			this._currentPosition += new Vector2 (this.speed, 0.0f);

		}

		// if player input is -ve move left
		if (this._playerInput < 0) {
			this._currentPosition -= new Vector2 (this.speed, 0.0f);

		}

		_CheckBounds ();
			
		this._transform.position = this._currentPosition;

	}


	// PRIVATE METHODS
	private void _CheckBounds(){

		// check if the player is moving out of the plane
		if (this._currentPosition.x < -290) {
			this._currentPosition.x = -290;
		}

		if (this._currentPosition.x > 290) {
			this._currentPosition.x = 290;
		}

	}
}
