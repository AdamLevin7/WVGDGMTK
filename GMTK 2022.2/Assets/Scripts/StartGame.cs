using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Events;

public class StartGame : MonoBehaviour
{
    

    void OnMouseDown()
    {
        DataSaver.doThing();
        SceneManager.LoadScene("Scenes/Room 1");
    }
}
