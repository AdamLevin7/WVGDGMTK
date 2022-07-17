using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataSaver
{

    // Start is called before the first frame update
    public static int deathCount;
    public static int[] nums = { 1, 2, 3, 4, 5, 6 };


    public static void doThing()
    {
        for (int t = 0; t < 6; t++)
        {
            int rand = Random.Range(0, 6);
            int temp = nums[rand];
            nums[rand] = nums[t];
            nums[t] = temp;

        }

        deathCount = 0;

    }

    public static int[] getTraps()
    {
        return nums;
    }

    public static void died()
    {
        deathCount++;
    }

    public static int getDeathCount()
    {
        return deathCount;
    }
}
