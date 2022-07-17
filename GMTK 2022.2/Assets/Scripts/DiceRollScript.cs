using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRollScript : MonoBehaviour
{
    private int diceroll;
    private int[] traps = { 1, 2, 3, 4, 5, 6 };
    private string[] trapStrings = { "left", "right", "up", "down", "bomb", "idk" };
    public Animator animator;
    public LeftArrowController LA;
    public RightArrowController RA;
    public UpArrowController UA;
    public DownArrowController DA;

    // Start is called before the first frame update
    void Start()
    {

        for (int t = 0; t < 6; t++)
        {
            int rand = Random.Range(0, 5);
            int temp = traps[rand];
            traps[rand] = traps[t];
            traps[t] = temp;
        }
        StartCoroutine(InfiniteLoop());
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
                int temp = traps[diceroll] - 1;

                if (trapStrings[traps[temp] - 1].Equals("right"))
                {
                    RA.ShootRight();
                }

                if (trapStrings[traps[temp] - 1].Equals("left"))
                {
                    LA.ShootLeft();
                }
                if (trapStrings[traps[temp] - 1].Equals("up"))
                {
                    UA.ShootUp();
                }
                if (trapStrings[traps[temp] - 1].Equals("down"))
                {
                    DA.ShootDown();
                }
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