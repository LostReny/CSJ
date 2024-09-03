using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Velocidade player")]
    public float speed;
    private Rigidbody2D rig;
    private Vector2 _direction;

    public Vector2 direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

    public void Start()
    {
        rig = GetComponent<Rigidbody2D>();
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

    }

    
    #endregion
}
