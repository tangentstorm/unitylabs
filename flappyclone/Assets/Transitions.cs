using UnityEngine;
using System.Collections;

public class Transitions : StateMachineBehaviour {

  // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
  override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
  //    GameWorld.HideBird();
        Debug.Log("transition to next state with hash: " + stateInfo.shortNameHash);
  }

}
