using System.Collections;
using UnityEngine;
public class Collision_rules : MonoBehaviour
{
    Animator _animator;
    string state_anim;
    string idle = "idle_bubble";
    string death = "death_bubble";
    Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void ChangeAnim(string newState)
    {
        if (newState == state_anim)
        {
            return;
        }
        _animator.Play(newState);
        state_anim = newState;
    }

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        ChangeAnim(idle);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void EndGame()
    {
        game_manage.instance.GameOver();
    }
    void WonGame()
    {
        game_manage.instance.GameWon();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("bullet"))
        {
            
        }
        else
        {
            ChangeAnim(death);
            Invoke("EndGame", 0.4f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("finish"))
        {
            Invoke("WonGame", 0.4f);
        }
    }
}
