using UnityEngine;
using System.Collections;

public class GameFunction : MonoBehaviour {
	public GameObject Enemy;
	public float time;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 0.5f) {
			Vector3 pos = new Vector3(Random.Range(-2.5f, 2.5f), 4.5f, 0);
			Instantiate(Enemy, pos, transform.rotation);
			time = 0f;
		}
	}
}
