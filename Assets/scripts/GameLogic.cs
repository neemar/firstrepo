using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {
	public Text textUI;
	public Transform player;
	public Transform goal;
	bool hasFoundTreasure = false;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		if (player.position.x < -100f) {
			textUI.text = "Too far left!"; 
		}
		if ((goal.position - player.position).magnitude < 50f) {
			textUI.text = "space blah win blah"; 
		}
		if ((goal.position - player.position).magnitude < 5f) {
			textUI.text = "press space idiot";
			if ( Input.GetKeyDown (KeyCode.Space)) {
				hasFoundTreasure = true;
				//textUI.text = "you made it";
			}

		}
	if (hasFoundTreasure) {
			textUI.text = "you win";
		}
	}

}
