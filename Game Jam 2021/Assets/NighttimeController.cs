using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NighttimeController : MonoBehaviour
{
    public Material dayMat, nightMat;
    public Light light;
    private bool night;
    private float start = 0.0f;
    private Color nightColor = Color.grey;
    private Color catVisionColor;
    private float fadeTime = 3.0f;
    public static float visionFadeTracker = 3.0f;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        night = true;
    }

    private void Start()
    {
        catVisionColor = light.color;
    }

    private void Update()
    {
        // Changes skybox
        if (night)
        {
            if (start == 0.0f && visionFadeTracker != 0.0f) // Starts tracking vision fade transition
            {
                visionFadeTracker = 0.0f;
            }

            start += 1 * Time.deltaTime; // tracks time
            if (start >= fadeTime)
            {
                RenderSettings.skybox = nightMat;
            }

            if (visionFadeTracker < fadeTime)
            {
                if (!(SimpleCapsuleWithStickMovement.animal is null) && SimpleCapsuleWithStickMovement.animal.name.Equals("cat"))
                {
                    light.color = Color.Lerp(light.color, catVisionColor, visionFadeTracker);
                }
                else
                {
                    light.color = Color.Lerp(light.color, nightColor, visionFadeTracker);
                }

                visionFadeTracker += 1 * Time.deltaTime;
            }
        }
    }
}
