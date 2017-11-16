using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

	private Material material;
	private GameObject slider;
	void Start () {
		material = gameObject.GetComponent<SpriteRenderer> ().material;
		slider = GameObject.FindGameObjectWithTag ("cursor");
	}

	// Update is called once per frame
	void Update () {
		if (gameObject.layer == LayerMask.NameToLayer ("platform2")) { //change material properties according to slider position
			material.SetFloat ("_RightLimit", slider.transform.position.x);
		} else {
			material.SetFloat ("_LeftLimit", slider.transform.position.x);
		}
	}
}
