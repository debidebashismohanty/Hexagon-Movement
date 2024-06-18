using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ThirdPersionMovement : MonoBehaviour
{
    public Transform cam;
    public CharacterController controler;
    public float speed=6.0f;
    public float turnSmoothTime = 0.2f;
    float turnSmothVelocity;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle=Mathf.Atan2(direction.x, direction.y)*Mathf.Rad2Deg+cam.eulerAngles.y;
            float angle=Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmothVelocity,turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir=Quaternion .Euler(0f,targetAngle,0)*Vector3.forward;
            controler.Move(moveDir.normalized* speed*Time.deltaTime);
        }
    }
}
