using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLE
	private int _scoreValue;
	private int _livesValue;

	// PUBLIC ACCESS METHODS
	public int ScoreValue{
		get{
			return this._scoreValue;
		}
		set{ 
			this._scoreValue = value;
			this.scoreLabel.text = "Score: " + this._scoreValue;
		}
	}

	public int LivesValue{
		get{
			return this._livesValue;
		}
		set{ 
			this._livesValue = value;
			if (this._livesValue <= -1) {
				this._endGame ();
			}
			this.livesLabel.text = "Lives: " + this._livesValue;
		}
	}

	//PUBLIC INSTANCE VARIABLE
	public int cloudNumber = 3;
	public CloudController cloud;
	public PlaneController plane;
	public IslandController island;
	public Text livesLabel;
	public Text scoreLabel;
	public Text gameOverLabel;
	public Text highScoreLabel;


	// Use this for initialization
	void Start () {
		this._Initialize ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// PRIVATES METHODS
	private void _Initialize(){

		this.ScoreValue = 0;
		this.LivesValue = 3;
		this.gameOverLabel.gameObject.SetActive (false);
		this.highScoreLabel.gameObject.SetActive (false);

		for (int cloudCount = 0; cloudCount < this.cloudNumber; cloudCount++) {
			Instantiate (this.cloud.gameObject);
		}
	}

	private void _endGame(){
		this.highScoreLabel.text = "High Score: " + this._scoreValue;
		this.gameOverLabel.gameObject.SetActive (true);
		this.livesLabel.enabled = false;
		this.scoreLabel.enabled = false;
		this.highScoreLabel.gameObject.SetActive (true);
		this.plane.gameObject.SetActive (false);
		this.island.gameObject.SetActive (false);
	}
}
