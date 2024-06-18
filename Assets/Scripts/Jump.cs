using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public GameObject sphere;
    public GameObject tag1;
    public Vector3 sphereDup;
    public float jumpHeight;
    bool jumpEnabled = false;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 beforePos=new Vector3(0, 0, 1.6f);
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    public void Update()
    {
        if (jumpEnabled)
        {
            transform.position += new Vector3(0, jumpHeight, 1.6f);
            jumpEnabled =false;
        }
        else
        {
            transform.position -= new Vector3(0, jumpHeight, 1.6f);

            //sphere.transform.position = sphereDup;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name== "Tag1")
        {
            tag1.SetActive(false);
            jumpEnabled = true;
        }
    }
}
