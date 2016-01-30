using UnityEngine;
using System.Collections;

public class Demonio : MonoBehaviour {
	int demonType;
	int lives;
	int rage;
	public Sprite demonioPadre;
	public Sprite demonioHijo1;
	public Sprite demonioHijo2;
	public Sprite demonioHijo3;
	public GameObject patron1;
	public GameObject patron2;
	public GameObject patron3;
	GameObject ataque;
	// Use this for initialization
	void Start () {
		Sprite s = new Sprite();
		if (GameManager.IsTimeForABigDemon()) {
			demonType = 0;
			rage = 0;
			lives = 3;
			s = demonioPadre;
		} else {
			demonType = Random.Range(1,4);
			switch(demonType) {
			case 1:
				ataque = patron1;
				s = demonioHijo1;
				break;
			case 2:
				ataque = patron2;
				s = demonioHijo2;
				break;
			case 3:
				ataque = patron3;
				s = demonioHijo3;
				break;
			}
			lives = 1;
			rage = 20;
			Instantiate(ataque);
		}
		this.GetComponent<SpriteRenderer>().sprite = s;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			GameManager.KillDemon();
		} else {
			if (this.transform.localScale.x < 1f) {
				this.transform.localScale += new Vector3(GameManager.currentSpeed, GameManager.currentSpeed) * Time.deltaTime;
			} else {
			}
		}
	
	}
}
	