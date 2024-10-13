using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    private int currentScore = 0;


    public void Increment()
    {
        currentScore++;
        ScoreText.text = currentScore.ToString();
        if(currentScore == 8){
            SceneManager.LoadScene("WinMenu");
        }
    }
}