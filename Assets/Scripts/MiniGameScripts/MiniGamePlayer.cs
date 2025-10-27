using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePlayer : MonoBehaviour
{
    Rigidbody2D _rigidbody;

    public float forwordSpeed = 3f;
    public float moveSpeed = 4f;

    public bool isDead = false;
    float deathCooldown = 0f;

    MiniGameManager miniGameManager;

    private void Start()
    {
        miniGameManager = MiniGameManager.instance;

        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (isDead) return;

        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 v = _rigidbody.velocity;
        v.x = forwordSpeed;               // 자동 전진
        v.y = vertical * moveSpeed;       // 위아래 조작
        _rigidbody.velocity = v;

    }
}