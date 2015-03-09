using System;
using UnityEngine;

public class GameWorld : MonoBehaviour {

  static GameWorld self; // singleton
  public BirdController bird;
  private Vector3 startPos = Vector3.zero;

  public void Awake() {
    if (self == null) self = this; else Destroy(this);
  }

  public void Start() {
    self.startPos = bird.transform.position;
  }

  public static void DropBird() {
    self.bird.GetComponent<Rigidbody2D>().isKinematic = false;
    Debug.Log("bird should be falling.");
  }

  public static void HoldBird() {
    self.bird.transform.position = self.startPos;
    self.bird.GetComponent<Rigidbody2D>().isKinematic = true;
  }

  public static void HideBird() {
    self.bird.gameObject.SetActive(false);
  }

  public static void ShowBird() {
    self.bird.gameObject.SetActive(true);
  }

  public static void Flap() {
    self.bird.Flap();
  }


}
