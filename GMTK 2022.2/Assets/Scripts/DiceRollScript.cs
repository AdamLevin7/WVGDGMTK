using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRollScript : MonoBehaviour
{
    private int diceroll;
    private int[] traps = new int[6];
    private int[] trapnumber = { 1, 2, 3, 4, 5, 6 };
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InfiniteLoop());
        /*
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
        */
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator InfiniteLoop()
    {
        WaitForSeconds waitTime = new WaitForSeconds(2);
        while (true)
        {
            //var aa;
            Roll();
            if (animator.GetBool("isRolling") == true)
            {
                animator.SetBool("isRolling", false);
                animator.SetInteger("roll", diceroll);
            }
            else
            {
                animator.SetBool("isRolling", true);
            }
            yield return waitTime;
            
        }
    }

    void Roll()
    {
        diceroll = Random.Range(1, 6);
    }
}
