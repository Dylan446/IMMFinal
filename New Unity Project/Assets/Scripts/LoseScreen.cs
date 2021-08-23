using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoseGame ()
    {
        SceneManager.LoadScene("Menu");
    }
}
