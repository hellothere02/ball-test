using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    static public SceneManager S;

    [SerializeField] private GameObject startCanvas;
    [SerializeField] private GameObject endPanel;
    [SerializeField] private Text resultOfGame;
    [SerializeField] private Text result;

    private float startTime;
    private float lastResult;

    private void Start()
    {
        S = this;
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            if (endPanel.activeInHierarchy)
            {
                endPanel.SetActive(false);
            }
            startCanvas.SetActive(true);
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        startCanvas.SetActive(false);
        startTime = Time.time;
        Movement.S.BackToStartPosition();
    }

    public void ShowResult()
    {
        endPanel.SetActive(true);
        result.text = lastResult.ToString();
        resultOfGame.text = null;
    }

    public void loseGame()
    {
        resultOfGame.text = "You lose";
        startCanvas.SetActive(true);
        endPanel.SetActive(true);
        result.text = null;
        Time.timeScale = 0;
    }

    public void WinGame()
    {
        resultOfGame.text = "You win";
        startCanvas.SetActive(true);
        endPanel.SetActive(true);
        lastResult = Time.time - startTime;
        result.text = lastResult.ToString();
        Time.timeScale = 0;
    }
}
