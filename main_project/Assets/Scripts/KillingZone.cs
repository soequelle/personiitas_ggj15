using UnityEngine;
using System.Collections;

public class KillingZone : MonoBehaviour {
	private GamePlay gp;

	void Awake(){
		gp = GameObject.Find ("GamePlay").GetComponent<GamePlay> ();
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.gameObject.tag == "Player"){
			//Destroy (gameObject);
			Destroy (coll.gameObject);
			gp.FinishGame();
			
		}
		
	}
}
