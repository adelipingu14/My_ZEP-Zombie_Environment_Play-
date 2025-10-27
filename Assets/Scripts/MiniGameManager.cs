using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void GameOver()
    {
        Debug.Log("게임 오버 발생! 씬 리셋합니다.");
        // 일단 재시작
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartMiniGame()
    {
        Debug.Log("청소를 시작합니다!");
    }
}

