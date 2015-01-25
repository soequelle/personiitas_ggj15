using UnityEngine;
using System.Collections;

public class Paredes : MonoBehaviour {
	private GameObject player;
	// Use this for initialization
	void Awake () {
		player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		float ye = player.transform.position.y;
		float xe = this.transform.position.x;
		transform.position = new Vector3 (xe,ye,-1);
	}
}
