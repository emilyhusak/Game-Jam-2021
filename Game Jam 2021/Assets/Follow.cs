using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject toFollow, follower;
    public Vector3 dist;

    // Update is called once per frame
    void Update()
    {
        follower.transform.position = toFollow.transform.position + dist;
    }
}
