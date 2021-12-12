using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSave : MonoBehaviour
{
    private int currentSceneIndex;

    public void LoadLevel()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedLevel", currentSceneIndex);
        SceneManager.LoadScene(0);
    }
}
