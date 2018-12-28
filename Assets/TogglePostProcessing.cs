using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TogglePostProcessing : MonoBehaviour
{
    public PostProcessVolume volumeA;
    public PostProcessVolume volumeB;

    void TogglePostProcess()
    {
        if (volumeA.enabled)
        {
            volumeA.enabled = false;
            volumeB.enabled = true;
        }
        else
        {
            volumeA.enabled = true;
            volumeB.enabled = false;
        }
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 30), "TogglePostProcess"))
        {
            TogglePostProcess();
        }
    }
}
