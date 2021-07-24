using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NighttimeController : MonoBehaviour
{
    public Material nightMat;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        RenderSettings.skybox = nightMat;
    }
}
