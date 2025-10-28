using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retrybutton : MonoBehaviour
{
    public void RestartMenu()
    {
        SceneManager.LoadScene("MiniGameScene");
    }
}
