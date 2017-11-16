using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpSpeed;
	private GameObject slider;
	private Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = gameObject.GetComponent<Rigidbody2D> ();
		slider = GameObject.FindGameObjectWithTag ("cursor");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (new Vector3 (-speed*Time.deltaTime,0,0));
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (new Vector3 (speed*Time.deltaTime,0,0));
		}
		if (Input.GetKeyDown (KeyCode.W)) { //TODO add gounded check (for now it can jump indefinitely)
			rigidbody.AddForce (new Vector2 (0, jumpSpeed), ForceMode2D.Impulse);

		}
		if (transform.position.x > slider.transform.position.x) { //change layer according to position relative to slider
			gameObject.layer = LayerMask.NameToLayer ("platform1");
		} else {
			gameObject.layer = LayerMask.NameToLayer ("platform2");
		}
	}
}
