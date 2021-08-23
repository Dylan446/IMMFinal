using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class wallDamage : MonoBehaviour
{
    public GameObject lifeText;
    public static int lifeCount = 3;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && lifeCount == 1)
        {
            print("Level failed!");
            SceneManager.LoadScene("LoseScreen");
        }

        if (collider.gameObject.tag == "Player")
        {
            print("You lost a life!");
            lifeCount--;

            Update();
        }
        void Update()
        {
            print(+lifeCount);
            lifeText.GetComponent<Text>().text = "LIVES: " + lifeCount;
        }
    }
}
