using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
        public static GameManager instance; 

        private void Awake()
        {
            // 씬에 단 하나만 존재하게
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject); 
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
