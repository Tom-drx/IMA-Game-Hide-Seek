using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using BITalino;


public class FogController : MonoBehaviour
{
    //public BITalinoDevice bitalinoDevice;
    [SerializeField] private Color fogColor = Color.gray;
    [SerializeField] private float minFogDensity = 0.01f;
    [SerializeField] private float maxFogDensity = 0.7f;
    [SerializeField] private float fogDensity = 0.6f;
    private float fogStartDistance = 10f;
    private float fogEndDistance = 100f;

    private void Update()
    {
        // Lower fog density by 0.05 when the 'X' key is pressed
        if (Input.GetKeyDown(KeyCode.X))
        {
            fogDensity = Mathf.Clamp(fogDensity - 0.05f, minFogDensity, maxFogDensity);
        }
        // Increase fog density by 0.05 when the 'Y' key is pressed
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            fogDensity = Mathf.Clamp(fogDensity + 0.05f, minFogDensity, maxFogDensity);
        }

        //int rawValue = bitalinoDevice.GetAnalogValue(0); // Assuming heartbeat data is on analog channel 0
        float normalizedValue = Mathf.InverseLerp(0, 1023, 1); // Normalize raw value to a range of 0-1

        // Calculate the fog density based on the heartbeat value
        fogDensity = Mathf.Lerp(minFogDensity, maxFogDensity, normalizedValue);

        RenderSettings.fog = true;
        RenderSettings.fogColor = fogColor;
        RenderSettings.fogDensity = fogDensity;
        RenderSettings.fogStartDistance = fogStartDistance;
        RenderSettings.fogEndDistance = fogEndDistance;
    }
}