using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	int playerLives = 3;
	public static float currentSpeed = 0.25f;	
	static int demonLife = 100;
	float speedIncrement = 0.25f;
	int demonLifeIncrement = 50;
	static int currentLife = 0;
	int demonChildCounter = 0;
	int demonCounter = 0;
	public GameObject demon;
	// Use this for initialization
	public static bool IsTimeForABigDemon() {
		return currentLife >= demonLife;
	}
	public static void KillDemon() {
	}
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		var demonioEnEscena = FindObjectOfType<Demonio>();
		if (demonioEnEscena) {
			
		} else {
			Instantiate(demon);
		}
	}
}
