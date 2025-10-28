using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager instance;
    public GameObject GameoverPanel;
    public GameObject GameClearPanel;

    private int currentScore = 0;
    private void Awake()
    {
        instance = this;
        Time.timeScale = 1.0f;
    }

    public void GameOver()
    {
        Debug.Log("게임 오버!");
        Time.timeScale = 0;
        GameoverPanel.SetActive(true);
    }

    public void GameClear()
    { 
        Time.timeScale = 0;
        GameClearPanel.SetActive(true);
    }

    public void TotheMain()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log("Score: " + currentScore);

        if (currentScore >= 7)
        {
            GameClear();
        }
    }
}

