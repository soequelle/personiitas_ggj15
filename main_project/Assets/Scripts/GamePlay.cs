using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour {
	public bool game=true;
	public GameObject HUDGameOver;
	public GameObject HUDWin;
	public int melodies=0;
	public Text melodiesText;
	public GameObject currentPlatform;
	public GameObject lastPlatform;

	private LevelSounds ls;
	private PlayerController player;

	void Awake(){
		player= GameObject.FindWithTag("Player").GetComponent<PlayerController> ();
		ls = GameObject.Find ("LevelSounds").GetComponent<LevelSounds> ();
	}

	void Update(){
		//if (ls.currentSound == ls.sounds.Length) {
		if (ls.currentSound == 20) {
			GameWin();
		}
	}

	/*
	void FixedUpdate(){
		if (Input.touchCount ==1){
			Touch touch = Input.GetTouch (0);
			if (touch.position.x < Screen.width/2){
				print("Derecha");
			}else if(touch.position.x > Screen.width/2){
				print("Izquierda");
			}
		}

	}*/

	public void addMelody(int value){
		melodies = melodies+value;
		melodiesText.text=melodies.ToString();
	}

	public void GameStart(){
		game=true;
		player.initGame();
		
	}
	
	public void GameWin(){
		game=false;

		HUDWin.SetActive (true);
		HUDWin.audio.Play ();
		player.finishGame ();
		if (melodies >= PlayerPrefs.GetInt ("Score")) {
			PlayerPrefs.SetInt ("Score", melodies);
			PlayerPrefs.Save ();
		}
		audio.Play ();
	}
	
	public void FinishGame(){
		game=false;

		HUDGameOver.SetActive (true);
		HUDGameOver.audio.Play ();
		player.finishGame ();

	}
	

}
