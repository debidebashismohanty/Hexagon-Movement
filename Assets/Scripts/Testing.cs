using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public GameObject T1;
    public GameObject T2;
    public GameObject character;
    Rigidbody d_rigidbody;
     public float d_speed;
     public float r_speed;
    public Camera cam;

    float tiltAngle = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        d_rigidbody = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name== "T1"|| other.name == "T3")
        {
            Debug.Log("GameOverrrrrrrrrr");
            T2.SetActive(false);

        }
    }
    void OnT2()
    {
        T2.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            //d_rigidbody.velocity = transform.forward* Time.deltaTime * d_speed;
            this.transform.Translate(Vector3.forward * d_speed * Time.deltaTime);
            character.GetComponent<Animator>().enabled = true;

        }
        else
        {
            character.GetComponent<Animator>().enabled= false;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            //d_rigidbody.velocity = -transform.forward* Time. deltaTime * d_speed;
            this.transform.Translate(Vector3.back * d_speed * Time.deltaTime);
            character.GetComponent<Animator>().enabled = true;
        }
        else
        {
            character.GetComponent<Animator>().enabled = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate the sprite about the Y axis in the positive direction
            //this.transform.Translate(Vector3.right* d_speed * Time.deltaTime);
            //float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            //float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
            //Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
            //cam.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * r_speed, Space.World);
            character.GetComponent<Animator>().enabled = true;

        }
        else
        {
            character.GetComponent<Animator>().enabled = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate the sprite about the Y axis in the negative direction
            //this.transform.Translate(Vector3.left* d_speed * Time.deltaTime);
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * r_speed, Space.World);
            character.GetComponent<Animator>().enabled = true;
        }
        else
        {
            character.GetComponent<Animator>().enabled = false;
        }


        if (Input .GetKeyDown(KeyCode.D)) 
        {
            T2.SetActive(false);
            Invoke("OnT2", 2);
        }
       
    }
}
