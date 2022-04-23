using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _endScreen;
    [SerializeField] private GameObject _winText;
    [SerializeField] private GameObject _gameOverText;

    public static UI instance;

    private void Awake()
    {
        instance = this;
    }

    public void UpdateScoreText(int score)
    {
        _scoreText.text = "Score: " + score.ToString();
    }

    public void SetEndScreen(bool didWin)
    {
        _endScreen.SetActive(true);
        _winText.SetActive(didWin);
        _gameOverText.SetActive(!didWin);
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
