using UnityEngine;
using System;

[Serializable]
public class ScrollLayer {
  public GameObject gameObj;
  public float scrollFactor = 1f;

  public void ScrollBy(Vector2 amount) {
    gameObj.transform.position = (Vector2) gameObj.transform.position + scrollFactor * amount;
  }

}
