using UnityEngine;
using System.Collections;

public class Marca : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("start marca");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("update marca");
	}
	void OnMouseOver() {
		Destroy(this.gameObject);
	}
}