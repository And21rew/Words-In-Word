using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Input : MonoBehaviour
{
    [SerializeField] private Text inputWordUI;
    [SerializeField] private GameObject warn, win;
    [SerializeField] private string word;
    [SerializeField] private string[] answers;
    [SerializeField] private GameObject[] answersUI;
    [SerializeField] private Text[] answersText;
    private string inputWord;
    private int inputLimit;
    private int limitChar;

    void Start()
    {
        limitChar = word.Length;
        inputLimit = 0;
        inputWord = "";
        inputWordUI.text = inputWord;

        for (int i = 0; i < answers.Length; i++)
        {
            answersText[i].text = answers[i]; 
        }

        for (int i = 0; i < answers.Length; i++)
        {
            if (PlayerPrefs.GetInt("level" + SceneManager.GetActiveScene().ToString() + "word" + i.ToString()) == 1)
            {
                answersUI[i].SetActive(true);
            }
        }
    }

    void Update()
    {
        inputWordUI.text = inputWord;

        for (int i=0; i < answers.Length; i++)
        {
            if (inputWord == answers[i])
            {
                inputWord = "";
                inputLimit = 0;
                answersUI[i].SetActive(true);
                PlayerPrefs.SetInt("level" + SceneManager.GetActiveScene().ToString() + "word" + i.ToString(), 1);
                PlayerPrefs.SetInt("level" + SceneManager.GetActiveScene().ToString() + "progress", PlayerPrefs.GetInt("level" + SceneManager.GetActiveScene().ToString() + "progress") + 1);
            }
        }

        if (PlayerPrefs.GetInt("level" + SceneManager.GetActiveScene().ToString() + "progress") == answers.Length)
        {
            win.SetActive(true);
        }
    }

    public void Char(int number)
    {
        if (inputLimit < limitChar)
        {
            switch (number)
            {
                case 1:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 2:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 3:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 4:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 5:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 6:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 7:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 8:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 9:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 10:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 11:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 12:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 13:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 14:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 15:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 16:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 17:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 18:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 19:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 20:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 21:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 22:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 23:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 24:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 25:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 26:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 27:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 28:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 29:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 30:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 31:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 32:
                    inputWord += "�";
                    inputLimit++;
                    break;

                case 33:
                    inputWord += "�";
                    inputLimit++;
                    break;
            }
        }
        else
        {
            Debug.Log(inputLimit);
            Debug.Log(limitChar);
            StartCoroutine(ShowWarn());
        }
    }

    IEnumerator ShowWarn()
    {
        warn.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        warn.SetActive(false);
    }

    public void Clear()
    {
        inputWord = "";
        inputLimit = 0;
    }
}
