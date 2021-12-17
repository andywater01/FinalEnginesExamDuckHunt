using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TheTimer : MonoBehaviour
{
    float Timer;
    

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= 30.0f)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
