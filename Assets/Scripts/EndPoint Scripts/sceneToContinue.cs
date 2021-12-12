using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneToContinue : MonoBehaviour
{
    private int sceneToContinued;

    public void ContinueGame()
    {
        sceneToContinued = PlayerPrefs.GetInt("SavedLevel");

        if(sceneToContinued != 0)
        {
            SceneManager.LoadScene(sceneToContinued);
        }

        else
        {
            return;
        }
    }
}
