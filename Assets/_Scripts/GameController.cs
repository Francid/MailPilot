using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLE
	public int cloudNumber = 3;
	public CloudController cloud;

	// Use this for initialization
	void Start () {
		this._Initialize ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// PRIVATES METHODS
	private void _Initialize(){
		for (int cloudCount = 0; cloudCount < this.cloudNumber; cloudCount++) {
			Instantiate (this.cloud.gameObject);
		}
	}
}
