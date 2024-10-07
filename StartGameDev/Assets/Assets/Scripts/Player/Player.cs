using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Velocidade player")]
    public float speed;
    public float runSpeed;
    public float roolSpeed; 

    private float initialSpeed;
    private bool _isRunning;
    private bool _isRolling; 
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

    public bool isRolling
    {
        get { return _isRolling; }
        set { _isRolling = value; }
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
        OnRoll();
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


    private void OnRoll()
    {
        if (Input.GetMouseButtonDown(1))
        {
            speed = roolSpeed;
            _isRolling = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            speed = initialSpeed;
            _isRolling = false;
        }
    }
    
    #endregion
}
