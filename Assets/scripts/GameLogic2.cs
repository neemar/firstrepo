using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic2 : MonoBehaviour {
	public Text textUI;
	public Transform player;
	public Transform goal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player.position.x < -100f) {
			textUI.text = "You suck."; 
		}
		//if (player.position.x < 100f) {
		//textUI.text = "TTOO FAR RIGHT!";
		//}
		if ((goal.position - player.position).magnitude < 50f) {
			textUI.text = "Hint = unicorns";
			
		}
		if ((goal.position - player.position).magnitude < 10f) {
			textUI.text = "think about it...";
		}
}
}