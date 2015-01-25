using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	public Sprite playbtn;
	public Sprite pausebtn;
	public GameObject pausa;
	bool pause=false;


	public void OnClick(int id){
		switch (id) {
		case 0://Inicio
			Application.LoadLevel(0);
			break;
		case 1://Level2
			Application.LoadLevel(1);
			break;
		case 2://Pausa
			if(!pause){
				pause=true;
				pausa.GetComponent<Image>().sprite = playbtn;
				Time.timeScale=0;
			}else{
				pause=false;
				Time.timeScale=1;
				pausa.GetComponent<Image>().sprite = pausebtn;
			}
			break;
		}	
	}
}
