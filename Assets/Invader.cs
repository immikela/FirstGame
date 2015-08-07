using UnityEngine;
using System.Collections;

public class Invader : MonoBehaviour {
	bool pause = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (pause) {
			Time.timeScale = 0;
			return;
		}
		gameObject.transform.position += new Vector3(0,-0.01f,0);
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Bullet") {
			Destroy (col.gameObject);
			Destroy (gameObject);
		} else if (col.tag == "Ship") {
//			Time.timeScale = 0;
			pause = true;
		}
	}
}
