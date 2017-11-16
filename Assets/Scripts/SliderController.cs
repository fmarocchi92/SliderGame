using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderController : MonoBehaviour {

	private bool beingDragged;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		bool overSprite = GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);
		beingDragged = beingDragged && Input.GetButton("Fire1");
		if (overSprite)
		{
			//If we've pressed down on the mouse (or touched on mobile)
			if (Input.GetButton("Fire1"))
			{
				beingDragged = true;
			}
		}
		if (beingDragged) {
			//Set the position to the mouse position
			transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 0, 0.0f);
		}
	}
}
