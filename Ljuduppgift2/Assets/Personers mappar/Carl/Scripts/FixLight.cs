using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixLight : MonoBehaviour
{
    private void Update()
    {
        RenderSettings.ambientIntensity = 0.5f;
    }
}
