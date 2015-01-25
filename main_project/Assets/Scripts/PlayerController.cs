using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public int health=1;
	public float speed=75.0f;
	public bool game=true;
	float pantalla = Screen.width/2;
	float pos = 0;
	bool flag = true;
	float posx=0;
	float posfin=0;
	private GamePlay gp;

	void Awake(){
		gp = GameObject.Find ("GamePlay").GetComponent<GamePlay> ();
		posx=pantalla;
	}
	
	// Update is called once per frame
	void Update () {
		if (health == 0) {
			gp.FinishGame();
		}
	}

	void FixedUpdate () {
		if (game) {
						if (flag) {
								if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
										pos = Input.GetTouch (0).position.x;
										if (pos > pantalla) {
												//transform.position = Vector2.Lerp(transform.position, transform.position + Vector2.right, speed*Time.deltaTime);
												//rigidbody2D.AddForce(Vector2.right * speed * Time.deltaTime);
												//rigidbody2D.velocity = new Vector2(1*speed,rigidbody.velocity.x);
												Debug.Log ("Derecha");
												transform.position = new Vector3 (transform.position.x + 1, transform.position.y, transform.position.z);
												float posx = transform.position.x;
												posfin = (float)(posx + 1);
												float posy = transform.position.y;
												Vector3 position = new Vector3 (posfin, posy, 0);
										} else if (pos < pantalla) {

												transform.position = new Vector3 (transform.position.x - 1, transform.position.y, transform.position.z);
												float posx = transform.position.x;
												posfin = (float)(posx + 1);
												float posy = transform.position.y;
												Vector3 position = new Vector3 (posfin, posy, 0);
												//rigidbody2D.velocity = new Vector2(-1*speed,rigidbody.velocity.x);
												//Debug.Log ("Izquierda");
												//transform.position = Vector2.Lerp(transform.position, transform.position - Vector2.right, speed*Time.deltaTime);
										}
								}
						}
				}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if(coll.gameObject.tag == "Platform" && game){
			print("Sube");
			//rigidbody2D.AddForce(Vector2.up*speed*Time.deltaTime);
			rigidbody2D.AddForce (Vector2.up * speed,ForceMode2D.Impulse);
		}
	}

	public void damage(int value){
		health = health - value;
	}

	public void initGame(){
		game = true;
		rigidbody2D.gravityScale = 1;
	}

	public void finishGame(){
		game = false;
		rigidbody2D.gravityScale = 0;
	}
}
