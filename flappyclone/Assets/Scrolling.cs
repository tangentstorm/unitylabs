using UnityEngine;
using System.Collections.Generic;

public class Scrolling : MonoBehaviour {

  public Vector2 delta = new Vector2(-0.05f, 0);
  public List<ScrollLayer> objects;
  public bool scrolling = false;

  void Update() {
    if (scrolling) {
      foreach (var o in objects) o.ScrollBy(delta);
    }
  }
}
