using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public Player play;
    public float spawnRate = 1f;
    public GameObject hexagonPrefab;
    public float nextTimeSpawn = 0f;

    public Text count;
    private int startCount;

    public Text highScore;
    public int scoreCount;

    private void Start()
    {
        //startTime = Time.time;
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }
    // Update is called once per frame
    void Update()
    {
          scoreCount = startCount;
        if(startCount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", startCount);
            highScore.text = startCount.ToString();
        }
        if (Time.time> nextTimeSpawn)
        { 
            Instantiate(hexagonPrefab,Vector3.zero, Quaternion.identity);
            nextTimeSpawn = Time.time+1f/spawnRate;
            startCount++;
            count.text = startCount.ToString();
        }
        if (startCount>=100)
        {
            play.gameObject.SetActive(false);
            gameObject.SetActive(false);
            play.welldone.SetActive(true);
        }

    }
}
