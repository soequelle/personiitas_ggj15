using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdminLevel : MonoBehaviour {
	public int level=0;
	public Text score;
	// Use this for initialization
	void Start () {
		if (level == 0) {
			score.text = PlayerPrefs.GetInt("Score").ToString();
		}
	}
	

}
