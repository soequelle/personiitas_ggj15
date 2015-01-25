using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.gameObject.tag == "Player"){
			Destroy (gameObject);
			//Destroy (coll.gameObject);
			//coll.gameObject.GetComponent<BoxCollider2D>().isTrigger=true;
			
		}
		
	}
}
