using UnityEngine;
using System.Collections;

public class PlatformTrigger : MonoBehaviour {

	public BoxCollider2D platform;

	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.gameObject.tag == "Player"){
			platform.isTrigger=true;
			print("Trigger");

		}
		
	}


}
