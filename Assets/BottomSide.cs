using UnityEngine;
using System.Collections;

public class BottomSide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Enemy") {
			Destroy(col.gameObject);
		}
	}
}
