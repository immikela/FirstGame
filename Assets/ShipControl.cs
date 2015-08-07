using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {

	public GameObject Bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.position += new Vector3 (0.1f, 0, 0);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.position += new Vector3 (-0.1f, 0, 0);
		} else if (Input.GetKeyDown (KeyCode.Space)) {
			Vector3 pos = gameObject.transform.position + new Vector3(0, 0.6f, 0);
			Instantiate(Bullet, pos, gameObject.transform.rotation);
		}
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer) {
			if (Input.touchCount > 0) {
				if (Input.GetTouch (0).phase == TouchPhase.Moved) {
					//Vector3 pos = new Vector3 (Input.GetTouch(0).position.x, gameObject.transform.position.y, gameObject.transform.position.z);
					//gameObject.transform.position = pos;
					checkTouch (Input.GetTouch (0).position);
				}
			}
		}
		if (platform == RuntimePlatform.OSXEditor) {
			if (Input.GetMouseButtonDown (0)) {
				//Vector3 pos = new Vector3 (Input.mousePosition.x, gameObject.transform.position.y, gameObject.transform.position.z);
				//gameObject.transform.position = pos;
				checkTouch (Input.mousePosition);
			}
		}
	}

	void checkTouch(Vector3 pos) {
		Vector3 wp = Camera.main.ScreenToWorldPoint (pos);
		Vector2 touch = new Vector2 (wp.x, wp.y);
//		Collider2D hit = Physics2D.OverlapPoint (touch);
		Debug.Log (touch.x + " " + touch.y);

		Vector3 newpos = new Vector3 (touch.x, gameObject.transform.position.y, gameObject.transform.position.z);
		gameObject.transform.position = newpos;

		Vector3 bulletpos = newpos + new Vector3(0, 0.6f, 0);
		Instantiate(Bullet, bulletpos, gameObject.transform.rotation);
	}
}
