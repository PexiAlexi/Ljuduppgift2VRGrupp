using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lektion15
{ 
public class Firstpersoncontroller : MonoBehaviour
{
        [SerializeField]
        private CharacterController cc;

        [SerializeField]
        private Transform cam;

        [SerializeField]
        private int speed;
        [SerializeField]
        private int lookspeed;

        [SerializeField]
        private float lookXLimit;
        private float rotationX;
        private float rotationY;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 right = transform.TransformDirection(Vector3.right);

            float xmovment = Input.GetAxis("Horizontal");
            float zmovment = Input.GetAxis("Vertical");

            //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            Vector3 move = (forward * zmovment * speed) + (right * xmovment * speed);

            cc.Move(move * speed * Time.deltaTime);

            rotationX += -Input.GetAxis("Mouse Y");
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            cam.localRotation =  Quaternion.Euler(rotationX, 0, 0);


            rotationY = Input.GetAxis("Mouse X");
            transform.rotation = transform.rotation * Quaternion.Euler(0, rotationY * lookspeed, 0);


            
        
    }
}

}