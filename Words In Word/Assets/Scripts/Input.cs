using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Input : MonoBehaviour
{
    [SerializeField] private Text countHelpText;
    [SerializeField] private GameObject helpScreen;
    [SerializeField] private Text warnHelpText;

    [SerializeField] private Text inputWordText;
    [SerializeField] private Text[] answersText;
    [SerializeField] private GameObject warn, win;
    [SerializeField] private GameObject[] answersUIText, winOffObjects;
    [SerializeField] private string word;
    [SerializeField] private string[] answers;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip findWordSound;

    private string inputWord;
    private int inputLimit, limitChar;

    void Start()
    {
        if (!PlayerPrefs.HasKey("end" + SceneManager.GetActiveScene().buildIndex.ToString() + "level"))
        {
            PlayerPrefs.SetInt("end" + SceneManager.GetActiveScene().buildIndex.ToString() + "level", 0);
        }

        if (!PlayerPrefs.HasKey("level" + SceneManager.GetActiveScene().buildIndex.ToString() + "progress"))
        {
            PlayerPrefs.SetInt("level" + SceneManager.GetActiveScene().buildIndex.ToString() + "progress", 0);
        }

        for (int i = 0; i < answers.Length; i++)
        {
            if (!PlayerPrefs.HasKey("level" + SceneManager.GetActiveScene().buildIndex.ToString() + "word" + i.ToString()))
            {
                PlayerPrefs.SetInt("level" + SceneManager.GetActiveScene().buildIndex.ToString() + "word" + i.ToString(), 0);
            }
        }
        limitChar = word.Length;
        inputLimit = 0;
        ClearInput();

        for (int i = 0; i < answers.Length; i++)
        {
            answersText[i].text = answers[i]; 
        }

        for (int i = 0; i < answers.Length; i++)
        {
            if (PlayerPrefs.GetInt("level" + SceneManager.GetActiveScene().buildIndex.ToString() + "word" + i.ToString()) == 1)
            {
                answersUIText[i].SetActive(true);
            }
        }
    }

    void Update()
    {
        countHelpText.text = PlayerPrefs.GetInt("help").ToString();
        inputWordText.text = inputWord;
        for (int i=0; i < answers.Length; i++)
        {
            if (inputWord == answers[i] && !answersUIText[i].activeSelf)
            {
                PlayFindWordSound();
                ClearInput();
                answersUIText[i].SetActive(true);
                PlayerPrefs.SetInt("level" + SceneManager.GetActiveScene().buildIndex.ToString() + "word" + i.ToString(), 1);
                PlayerPrefs.SetInt("level" + SceneManager.GetActiveScene().buildIndex.ToString() + "progress", PlayerPrefs.GetInt("level" + SceneManager.GetActiveScene().buildIndex.ToString() + "progress") + 1);
                PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
            }
        }

        if (PlayerPrefs.GetInt("level" + SceneManager.GetActiveScene().buildIndex.ToString() + "progress") == answers.Length)
        {
            FinishLevel();
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
            StartCoroutine(ShowWarn());
        }
    }

    IEnumerator ShowWarn()
    {
        warn.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        warn.SetActive(false);
    }

    public void ClearInput()
    {
        inputWord = "";
        inputLimit = 0;
    }

    public void FinishLevel()
    {
        if (PlayerPrefs.GetInt("end" + SceneManager.GetActiveScene().buildIndex.ToString() + "level") == 0)
        {
            PlayerPrefs.SetInt("end" + SceneManager.GetActiveScene().buildIndex.ToString() + "level", 1);
            for (int i = 0; i < winOffObjects.Length; i++)
            {
                winOffObjects[i].SetActive(false);
            }
            win.SetActive(true);
            PlayerPrefs.SetInt("help", PlayerPrefs.GetInt("help") + 5);
        }
        else
        {
            for (int i = 0; i < winOffObjects.Length; i++)
            {
                winOffObjects[i].SetActive(false);
            }
            win.SetActive(true);
        }
    }

    public void ShowHelpScreen()
    {
        helpScreen.SetActive(true);
    }

    public void CloseHelpScreen()
    {
        helpScreen.SetActive(false);
    }

    public void UseHelp()
    {
        if (PlayerPrefs.GetInt("help") >= 3)
        {
            helpScreen.SetActive(false);
            PlayerPrefs.SetInt("help", PlayerPrefs.GetInt("help") - 3);

            for(int i = 0; i < answers.Length; i++)
            {
                if (!answersUIText[i].activeSelf)
                {
                    inputWord = answers[i];
                    break;
                }
            }
        }
        else
        {
            StartCoroutine(ShowWarnHelp());
        }
    }

    IEnumerator ShowWarnHelp()
    {
        warnHelpText.text = "����� ������� ����� ����� 3 ���������";
        yield return new WaitForSeconds(1.5f);
        warnHelpText.text = "";
    }

    public void PlayFindWordSound()
    {
        audioSource.PlayOneShot(findWordSound);
    }

    public void ClearOneCharInInput()
    {
        inputWord = inputWord.Remove(inputWord.Length - 1);
        inputLimit--;
    }
}
