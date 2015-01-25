using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {
	public int points=1;
	private SpawnControl spawnObj;
	private GamePlay gp;
	private LevelSounds ls;
	private SpawnUp spawnMax;
	private SpawnUp spawnMin;


	void Awake(){
		gp = GameObject.Find ("GamePlay").GetComponent<GamePlay> ();
		ls = GameObject.Find ("LevelSounds").GetComponent<LevelSounds> ();
		spawnMax= GameObject.Find ("SpawnMax").GetComponent<SpawnUp> ();
		spawnMin= GameObject.Find ("SpawnMin").GetComponent<SpawnUp> ();
		spawnObj = GameObject.Find ("SpawnControl").GetComponent<SpawnControl> ();
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if(coll.gameObject.tag == "Player"){
			//print("Pega");
			if(gp.currentPlatform==null){
				gp.currentPlatform=this.gameObject;
				gp.addMelody(points);
				audio.clip = ls.sounds [ls.currentSound];
				audio.Play();

			}else if(this.gameObject!=gp.currentPlatform){
				Destroy(gp.currentPlatform);
				gp.currentPlatform=this.gameObject;
				gp.addMelody(points);
				spawnMax.up();
				spawnMin.up();
				spawnObj.Spawn();

				audio.clip = ls.sounds [ls.currentSound];
				audio.Play();

			}

		

		}
		
	}

	void OnTriggerExit2D(Collider2D coll) {
		if(coll.gameObject.tag == "Player"){
			print("No Trigger");
			this.gameObject.GetComponent<BoxCollider2D>().isTrigger=false;
			
		}
		
	}


}
