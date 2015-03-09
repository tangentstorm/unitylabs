using UnityEngine;
using System.Collections;

public class BirdController : MonoBehaviour {

  public float flapForce = 5.0f;

  private Rigidbody2D body;
  private Animator anim;

  void Awake() {
    body = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
  }

  void OnCollisionEnter2D(Collision2D c) {
    Debug.Log("collision! name:" + c.gameObject.name);
    if (c.gameObject.tag == "ceil") { } else {
      ScreenFlow.GameOver();
    }
  }

  public void Flap() {
    anim.SetTrigger("flap");
    body.AddForce(Vector2.up * flapForce, ForceMode2D.Impulse);
  }

  void Update() {
    if (Input.GetButtonDown("Jump")) Flap();
  }

}
