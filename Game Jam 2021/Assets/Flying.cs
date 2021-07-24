using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public string location;
    public GameObject player;
    public static bool hitTop = false;
    private float startTime = 0.0f;
    private float flyDuration = 3.0f;
    private Vector3 nextPos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "GrabVolumeBig")
        {
            if (location.Equals("top"))
            {
                hitTop = true;
                startTime = 0.0f;
                nextPos = new Vector3(player.transform.position.x, player.transform.position.y + 5, player.transform.position.z);
            }

            if (hitTop && location.Equals("bottom"))
            {
                startTime += Time.deltaTime;
                player.transform.Translate(Vector3.up * 3.0f);
                player.GetComponent<Rigidbody>().useGravity = false;
                hitTop = false;
            }
        }
    }
}
