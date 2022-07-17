using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Events;

public class Replay : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        SceneManager.LoadScene("Scenes/Title Screen");
    }
}
