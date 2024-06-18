using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    Rigidbody rb;
    public float movespeed = 10f;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity =new Vector3(transform.position.x, 0, transform.position.z);
            rb.velocity = player.transform.forward * movespeed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = -player.transform.forward * movespeed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = player.transform.right * movespeed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = -player.transform.right * movespeed;
        }
    }
}
