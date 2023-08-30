using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject doorSound;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        animator.SetTrigger("OpenDoor");
        doorSound.SetActive(true);
    }
}