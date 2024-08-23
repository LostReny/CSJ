using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Velocidade player")]
    public float speed;
    private Rigidbody2D rig;
    private Vector2 direction;


    public void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    public void FixedUpdate()
    {
        rig.MovePosition(rig.position + direction * speed * Time.fixedDeltaTime);
    }
}
