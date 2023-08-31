using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsScript : MonoBehaviour
{
    [SerializeField] private CharacterController player;
    [SerializeField] private GameObject footStepSoundsSource;

    private void Update()
    {
       

        if (player.velocity.z > 0.1 || player.velocity.z < -0.1 || player.velocity.x > 0.1 || player.velocity.x < -0.1)
        {
            footStepSoundsSource.SetActive(true);
            
        }
        else if (player.velocity.z == 0)
        {
            footStepSoundsSource.SetActive(false);
        }
    }   
      
}
