using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStart : MonoBehaviour
{
    void Start()
    {
        if (!PlayerPrefs.HasKey("score"))
            PlayerPrefs.SetInt("score", 0);

        if (!PlayerPrefs.HasKey("help"))
            PlayerPrefs.SetInt("help", 5);
    }
}
