using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpInMenu : MonoBehaviour
{
    [SerializeField] private Text countText;

    void Start()
    {
        countText.text = "Количество подсказок: " + PlayerPrefs.GetInt("help").ToString();
    }

    void Update()
    {
        countText.text = "Количество подсказок: " + PlayerPrefs.GetInt("help").ToString();
    }
}
