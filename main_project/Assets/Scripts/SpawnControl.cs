using UnityEngine;
using System.Collections;

public class SpawnControl : MonoBehaviour {

	public GameObject[] obj;
	public GameObject spawnMin;
	public GameObject spawnMax;
	public bool time=false;
	public float timeSpawn=5.0f;

	private LevelSounds ls;

	void Awake(){
		ls = GameObject.Find ("LevelSounds").GetComponent<LevelSounds> ();
	}

	void Start () {
		if (time) {
			InvokeRepeating ("Spawn", 0, timeSpawn);
		}
	}
	
	public void Spawn(){
		ls.currentSound++;

		float rand = Random.Range (spawnMin.transform.position.x, spawnMax.transform.position.x);
		GameObject newPlatform=Instantiate (obj [Random.Range (0, obj.GetLength (0))], new Vector3(rand,spawnMin.transform.position.y,spawnMin.transform.position.z), Quaternion.identity) as GameObject;
		//newPlatform.audio.clip = ls.sounds [ls.currentSound];

	}
}
