using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToHomebutton : MonoBehaviour
{
    public void TotheMain()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1.0f;
    }
}
