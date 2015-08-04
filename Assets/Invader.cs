using UnityEngine;
using System.Collections;

public class Invader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3(0,-0.01f,0);
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Ship" || col.tag == "Bullet") {
			Destroy(col.gameObject);
			Destroy (gameObject);
		}
	}
}
