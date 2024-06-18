using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Spawner spawner_H;
    public float moveSpeed = 600f;
    public float movement = 0f;
    public GameObject wellcomeUI;
    public GameObject restart;
    public GameObject exitUI;
    public GameObject welldone;
    


    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        movement = Input.GetAxisRaw("Horizontal");
        //int i = 0;
        //while (i<Input.touchCount)
        //{
        //    if(Input.GetTouch(i).position.x> screenWidth / 2)
        //    {
                
        //    }
        //}

    }
    public void LeftButton()
    {
        movement = 1;
        //Invoke("exit", 0.1f);
    }
    public void exit()
    {
        movement = 0;
    }
    public void RighttButton()
    {
        movement = -1;
        //Invoke("exit", 0.1f);

    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, -movement * Time.fixedDeltaTime * moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        //spawner_H.hexagonPrefab.SetActive(false);
        spawner_H.gameObject.SetActive(false);
        restart.SetActive(true);
        exitUI.SetActive(true);
    }
    public void OnApplicationQuit()
    {
        OnApplicationQuit();
    }
   
    public void Restart()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
