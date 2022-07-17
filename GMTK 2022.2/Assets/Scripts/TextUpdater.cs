using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour
{
    public Text DeathCount;

    void Update()
    {
        DeathCount.text = ("Death Count: " + DataSaver.getDeathCount());
    }
}
