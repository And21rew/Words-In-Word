using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountFps : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }
}