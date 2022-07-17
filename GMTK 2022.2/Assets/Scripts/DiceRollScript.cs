using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRollScript : MonoBehaviour
{
    private int diceroll;
    private int[] traps = { 1, 2, 3, 4, 5, 6 };
    public Animator animator;
    public LeftArrowController LA;
    public RightArrowController RA;
    public UpArrowController UA;
    public DownArrowController DA;
    public LeftBombController LB;
    public RightBombController RB;
    public UpBombController UB;
    public DownBombController DB;


    // Start is called before the first frame update
    void Start()
    {

        DataSaver.getTraps(traps);
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
                yield return waitTime;
                if (traps[diceroll] == 1)
                {
                    RA.ShootRight();
                }

                if (traps[diceroll] == 2)
                {
                    LA.ShootLeft();
                }
                if (traps[diceroll] == 3)
                {
                    UA.ShootUp();
                }
                if (traps[diceroll] == 4)
                {
                    DA.ShootDown();
                }
                if (traps[diceroll] == 5)
                {
                    UB.UpBombs();
                    LB.LeftBombs();
                }
                if (traps[diceroll] == 6)
                {
                    DB.DownBombs();
                    RB.RightBombs();
                }

            }
            else
            {
                animator.SetBool("isRolling", true);
                yield return waitTime;
            }
        }
    }

    void Roll()
    {
        diceroll = Random.Range(1, 6);

    }
}