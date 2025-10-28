using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cartrigger : MonoBehaviour
{
    public GameObject beforewestart;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        Debug.Log("유일하게 가진 재산인 쓸만한 차량이다.\n 외부 청소를 시작하겠습니까? 1. Yes 2. No");

        beforewestart.SetActive(true);
    }
}
