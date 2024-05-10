using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GameController : MonoBehaviour
{

    public int Score;
    public TextMeshProUGUI scoreText;

    void Start(){
        Time.timeScale = 1;
    }

    public void RestartGame(){
        SceneManager.LoadScene(0);
    }
}
