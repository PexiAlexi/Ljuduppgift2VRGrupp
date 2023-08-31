using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsHardSurface : MonoBehaviour
{
    [SerializeField] private CharacterController player;
    [SerializeField] private GameObject footStepSoundsSource;


    private void Update()
    {
        Debug.Log(player.velocity.z);

        if(player.velocity.z > 0.1 || player.velocity.z < -0.1 || player.velocity.x > 0.1 || player.velocity.x < -0.1)
        {
            footStepSoundsSource.SetActive(true);
            Debug.Log("Jag går faktiskt");
        }
        else if(player.velocity.z == 0)
        {
            footStepSoundsSource.SetActive(false);
        }
    }
}
