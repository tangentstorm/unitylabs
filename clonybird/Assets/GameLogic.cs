using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {

	static GameLogic self; // singleton
	Animator animator;

	public void Awake() {
		if (self == null) {
			self = this;
			self.animator = GetComponent<Animator>();
		} else Destroy(this);
	}

	public static void GameOver() {
		self.animator.SetTrigger("GameOver");
	}

}
