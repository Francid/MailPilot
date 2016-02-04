using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLE
	public GameController gameController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.CompareTag("Island")){
			// Play the sound
			this.gameController.ScoreValue += 100;
		}
		if(other.gameObject.CompareTag("Cloud")){
			//Play the Sound
			this.gameController.LivesValue -= 1;
		}

	}
}
