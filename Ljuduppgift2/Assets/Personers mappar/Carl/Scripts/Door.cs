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

    IEnumerator OpenDoorCouroutine()
    {
        yield return new WaitForSeconds(14);
        animator.SetTrigger("OpenDoor");
        doorSound.SetActive(true);
    }

    public void OpenDoor()
    {
        StartCoroutine(OpenDoorCouroutine());
    }
}