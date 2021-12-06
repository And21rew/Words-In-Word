using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpInMenu : MonoBehaviour
{
    [SerializeField] private Text countText;

    void Start()
    {
        countText.text = "���������� ���������: " + PlayerPrefs.GetInt("help").ToString();
    }

    void Update()
    {
        countText.text = "���������� ���������: " + PlayerPrefs.GetInt("help").ToString();
    }
}
