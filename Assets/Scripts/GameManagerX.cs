using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerX : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI gameOverText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        //if (isGameActive)
        //{
            //timeLeft -= Time.deltaTime;
            //timerText.SetText("Time: " + Mathf.Round(timeLeft));
            //if (timeLeft < 0)
            //{
                //GameOver();
            //}
        //}
    }
    public void UpdateScore(int scoreToAdd)
    {
        //if player gets coin it will gain not only a power up but a point
        //If player hits a blob with its furball teh score will update
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    public void Gameover()
    {
        gameOverText.gameObject.SetActive(true);
        //isGameActive = false;
    }
    public void MenuGame()
    {
        //SceneManager.LoadScene(Scene_WildCatMenu); //should load menu again will make a restart scene soon
    }
}
