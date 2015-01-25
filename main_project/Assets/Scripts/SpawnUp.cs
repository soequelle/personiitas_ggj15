using UnityEngine;
using System.Collections;

public class SpawnUp : MonoBehaviour {
	public float upValue=0.0f;

	public void up(){
		print ("Up " + gameObject.name + " value " + transform.position.y);
		transform.position = new Vector3 (transform.position.x, transform.position.y - upValue, transform.position.z);
	}
}
