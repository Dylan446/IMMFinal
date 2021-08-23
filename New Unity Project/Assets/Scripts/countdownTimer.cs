using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdownTimer : MonoBehaviour
{
    public GameObject timeText;
    float currentTime = 0;
    float startingTime = 30f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
        }
        else
        {
            print("You ran out of time!");
            SceneManager.LoadScene("LoseScreen");
        }
        timeText.GetComponent<Text>().text = "TIME: " + currentTime;


    }
}
