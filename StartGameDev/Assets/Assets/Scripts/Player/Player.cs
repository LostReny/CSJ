using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Velocidade player")]
    public float speed;
    public float runSpeed;

    private float initialSpeed;
    private bool _isRunning; 
    private Rigidbody2D rig;
    private Vector2 _direction;

    public Vector2 direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

    public bool isRunning
    {
        get { return _isRunning; }
        set { _isRunning = value; }
    }

    public void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        initialSpeed = speed;
    }

    public void Update()
    {
        Inputs();
        OnRun();
    }

    public void FixedUpdate()
    {
        Movement();
    }

    #region Movement

    private void Inputs()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void Movement()
    {
        rig.MovePosition(rig.position + _direction * speed * Time.fixedDeltaTime);
    }

    private void OnRun()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
            isRunning = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = initialSpeed;
            isRunning = false;
        }
    }

    
    #endregion
}
