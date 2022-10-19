using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
    private void OnCollisionEnter(Collision other_colission)
    {
        if (other_colission.gameObject.name == "Player")
        {
            other_colission.gameObject.transform.SetParent(transform);
        }
    }

    // OnCollisionExit is called when this collider/rigidbody has stopped touching another rigidbody/collider.
    private void OnCollisionExit(Collision other_colission)
    {
        if (other_colission.gameObject.name == "Player")
        {
            other_colission.gameObject.transform.SetParent(null);
        }
    }
}
