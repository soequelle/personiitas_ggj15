using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
	public int points=3;
	private GamePlay gp;
	
	void Awake(){
		gp = GameObject.Find ("GamePlay").GetComponent<GamePlay> ();
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.gameObject.tag == "Player"){
			Destroy (gameObject);
			gp.addMelody(points);
			
		}
		
	}
}
