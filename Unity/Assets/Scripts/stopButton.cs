using UnityEngine;
using System.Collections;

public class stopButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);

		if (aCollider2d) {
			GameObject obj = aCollider2d.transform.gameObject;
			if (obj.name == "stopLabel") {
				    Time.timeScale = 0;
			} else {
			    Time.timeScale = 1; // 画面を押すと再開する
			}
		}
	}
}
