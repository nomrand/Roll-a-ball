using UnityEngine;
using UnityEngine.Events;


public class GroundChecker : MonoBehaviour
{
    public UnityEvent OnEnterGround;
    public UnityEvent OnExitGround;
    private int enterNum = 0;
    // Called this method when GroundChecker touches a game object with another RigidBody or Collider component.
    private void OnTriggerEnter(Collider collision)
    {
        enterNum++;
        OnEnterGround.Invoke();
    }
    // Called this method when GroundChecker loses touch with other RigidBody or other game objects with collider components
    private void OnTriggerExit(Collider collision)
    {
        enterNum--;
        if (enterNum <= 0)
        {
            OnExitGround.Invoke();
        }
    }

}
