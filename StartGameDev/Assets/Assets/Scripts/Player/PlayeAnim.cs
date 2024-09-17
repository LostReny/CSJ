using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeAnim : MonoBehaviour
{
    private Player player;
    private Animator anim;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        OnMoveAnim();
        OnFlipAnim();
        OnRunAnin();
        
    }

    #region Movement

    public void OnMoveAnim()
    {
        if (player.direction.sqrMagnitude > 0)
        {
            anim.SetInteger("transition", 1);
        }
        else
        {
            anim.SetInteger("transition", 0);
        }
    }

    public void OnRunAnin()
    {
        if (player.isRunning == true)
        {
            anim.SetInteger("transition", 2);
        }
        else return;
    }
    #endregion

    #region Flip
    public void OnFlipAnim()
    {
        if (player.direction.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        else if (player.direction.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
    }

    #endregion
}
