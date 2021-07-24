using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public string location;
    public GameObject player;
    public static bool hitTop = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "GrabVolumeBig" && !(SimpleCapsuleWithStickMovement.animal is null) && SimpleCapsuleWithStickMovement.animal.name.Equals("bird"))
        {
            if (location.Equals("top"))
            {
                hitTop = true;
            }

            if (hitTop && location.Equals("bottom"))
            {
                player.transform.Translate(Vector3.up * 3.0f);
                player.GetComponent<Rigidbody>().useGravity = false;
                hitTop = false;
            }
        }
    }
}
