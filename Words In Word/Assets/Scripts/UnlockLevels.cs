using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevels : MonoBehaviour
{
    [SerializeField] private Text countWordsText;
    [SerializeField] private GameObject[] blocksLevels;
    [SerializeField] private Text warnText;
    //private readonly int CountWordsInAllLevels = 360;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        //PlayerPrefs.SetInt("help", 1000);
        countWordsText.text = "Всего угадано слов: " + PlayerPrefs.GetInt("score").ToString();

        if (PlayerPrefs.GetInt("score") >= 30)
        {
            blocksLevels[0].SetActive(false);
        }

        if (PlayerPrefs.GetInt("score") >= 60)
        {
            blocksLevels[1].SetActive(false);
        }

        if (PlayerPrefs.GetInt("score") >= 100)
        {
            blocksLevels[2].SetActive(false);
        }

        if (PlayerPrefs.GetInt("score") >= 150)
        {
            blocksLevels[3].SetActive(false);
        }

        if (PlayerPrefs.GetInt("score") >= 200)
        {
            blocksLevels[4].SetActive(false);
        }

        if (PlayerPrefs.GetInt("score") >= 255)
        {
            blocksLevels[5].SetActive(false);
        }

        if (PlayerPrefs.GetInt("score") >= 305)
        {
            blocksLevels[6].SetActive(false);
        }
    }

    public void ShowWarn(int needWord)
    {
        StartCoroutine(StartShowWarn(needWord));
    }

    IEnumerator StartShowWarn(int needWord)
    {
        warnText.text = "Нужно отгадать: "+ needWord + " слов";
        yield return new WaitForSeconds(1.5f);
        warnText.text = "";
    }
}
