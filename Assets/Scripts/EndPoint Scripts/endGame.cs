using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    public gameChecker gameManger;

    public
    void OnTriggerEnter()
    {
        gameManger.completeGame();
    }
}
