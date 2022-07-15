using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dicerollscript : MonoBehaviour
{
    private int diceroll;
    private int[] traps = new int[6];
    private int[] trapnumber = { 1, 2, 3, 4, 5, 6 };

    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;
        while (counter < 5)
        {
            Roll();
            if (trapnumber[diceroll] != 0)
            {
                traps[counter] = trapnumber[diceroll];
                trapnumber[diceroll] = 0;
                counter++;
            }
        }
        Debug.Log(traps);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Roll()
    {
        diceroll = Random.Range(1, 6);
    }
}
