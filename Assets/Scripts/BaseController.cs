using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody _rigidbody;

    [SerializeField] private SpriteRenderer characterRenderer;

    protected Vector2 movementDirection = Vector2.zero;
    public Vector2 MovementDirection => movementDirection;

    protected Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection => lookDirection;


    protected virtual void Awake()
    { 
        _rigidbody = GetComponent<Rigidbody>();
    }

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {

    }

    protected virtual void FixedUpdate()
    {

    }

    protected virtual void HandleAction()
    {

    }

    private void Movement(Vector2 direction)
    {

    }

    private void Rotate(Vector2 direction)
    {

    }
}
