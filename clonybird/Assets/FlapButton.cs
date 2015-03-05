using UnityEngine;
using System.Collections;

public class FlapButton : MonoBehaviour {

	void OnCollision2D (Collision2D c) {
		if (c.gameObject.tag == "ceil") {}
		else {
			GameLogic.GameOver();
		}
	}

}
