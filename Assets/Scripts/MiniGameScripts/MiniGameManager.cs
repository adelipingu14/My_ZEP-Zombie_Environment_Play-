using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        Debug.Log("게임 오버!");
        SceneManager.LoadScene("SampleScene"); 
    }



}

