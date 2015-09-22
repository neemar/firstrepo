using UnityEngine;
using System.Collections;

public class Cube1 : MonoBehaviour {

	public float moveSpeed = 500f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey (KeyCode.W) ) {
			transform.position += new Vector3(0f, 0f, -50f) * Time.deltaTime;
			transform.eulerAngles = new Vector3(0f, 0f, 0f);
			//transform.rotation is BAD
		} 
		if ( Input.GetKey (KeyCode.S) ) {
			transform.position += new Vector3(0f, 0f, 50f) * Time.deltaTime;
			transform.eulerAngles = new Vector3(0f, 180f, 0f);
		}
		if ( Input.GetKey (KeyCode.A) ) {
			transform.position += new Vector3(50f, 0f, 0f) * Time.deltaTime;
			transform.eulerAngles = new Vector3(0f, -90f, 0f);
		}
		if ( Input.GetKey (KeyCode.D) ) {
			transform.position += new Vector3(-50f, 0f, 0f) * Time.deltaTime;
			transform.eulerAngles = new Vector3(0f, 90f, 0f);
		}
		if ( Input.GetKey (KeyCode.E) ) {
			transform.position += new Vector3(0f, -1f, 0f);

		}
		if ( Input.GetKey (KeyCode.Q) ) {
			transform.position += new Vector3(0f, 1f, 0f);
		}

		Camera.main.transform.position = transform.position + new Vector3(-7f, 15f, 25f);

	
	}
}
