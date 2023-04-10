using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public float smoothBlend = 0.1f;
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }


    void Update()
    {
        Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        float randomNumber = Random.Range(0, 7);

        if (Input.GetMouseButtonDown(0))
        {
            if (randomNumber >= 0 && randomNumber <= 3)
            {
                _animator.SetBool("Attack_1", true);
            } else if (randomNumber > 3 && randomNumber <= 7)
            {
                _animator.SetBool("Attack_2", true);
            }
            
        }

        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool("Attack_1", false);
            _animator.SetBool("Attack_2", false);
        }
    }

    void Move(float x, float y)
    {
        _animator.SetFloat("Blend", y, smoothBlend, Time.deltaTime);
    }
}
