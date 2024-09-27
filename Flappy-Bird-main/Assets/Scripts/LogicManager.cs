using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    public GameObject GameOverScreen;
    public void AddScore(int scoreToAdd)
    {
        Score = Score + scoreToAdd;
        ScoreText.text = Score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
