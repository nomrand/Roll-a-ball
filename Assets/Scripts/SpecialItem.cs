using UnityEngine;
using UnityEngine.Events;

public class SpecialItem : Item
{
    public UnityEvent OnSpecialItem;

    // The call-back of contact trigger
    void OnTriggerEnter(Collider hit)
    {
        // Is the contact target “Player” tag?
        if (hit.CompareTag("Player"))
        {

            // Do some processing
            Destroy(gameObject);
            // occur event
            OnSpecialItem.Invoke();
        }
    }
}

