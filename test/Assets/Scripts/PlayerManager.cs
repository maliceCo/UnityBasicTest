using System;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Action OnDead;
    public Animator animator;

    private CharacterController characterController;
    private bool isRunning = false;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Update()
    {
        isRunning = false;
        if (Input.GetKey(KeyCode.A))
        {
            characterController.SimpleMove(Vector3.left * 3);
            if (!isRunning)
            {
                isRunning = true;
                animator.SetBool("Running", isRunning);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            characterController.SimpleMove(Vector3.right * 3);
            if (!isRunning)
            {
                isRunning = true;
                animator.SetBool("Running", isRunning);
            }
        }
        else if (!isRunning)
        {
            animator.SetBool("Running", isRunning);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
        OnDead?.Invoke();
    }
}