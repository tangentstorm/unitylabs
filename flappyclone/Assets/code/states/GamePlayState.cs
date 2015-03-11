using UnityEngine;
using System.Collections;

public class GamePlayState : StateMachineBehaviour {

  override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    GameWorld.DropBird();
    GameWorld.Flap(); // because the transition resets the bird's velocity
  }

}
