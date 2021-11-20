using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    public GameObject sastaGta;

    bool gamended = false;
    public float value = 2f;

    public void levelNext()
    {
        Debug.Log("End Point");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void endPhase()
    {
        Debug.Log("game over");
        if (gamended == false)
        {
            gamended = true;
            //restart();

        }
    }
    void restartUI()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
