using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NighttimeController : MonoBehaviour
{
    public Material dayMat, nightMat;
    public Light light;
    private bool night;
    private float start = 0.0f;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        night = true;
    }

    private void Start()
    {

    }

    private void Update()
    {
        if (night)
        {
            light.color -= (Color.white / 3.0f) * Time.deltaTime;
            start += 1 * Time.deltaTime; // tracks time
            if (start >= 3.0f)
            {
                RenderSettings.skybox = nightMat;
            }
        }
    }
}
