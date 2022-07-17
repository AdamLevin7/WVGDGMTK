using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataSaver
{

    // Start is called before the first frame update
    public static int[] traps = { 1, 2, 3, 4, 5, 6 };
    public static void Start()
    {

        for (int t = 0; t < 6; t++)
        {
            int rand = Random.Range(0, 6);
            int temp = traps[rand];
            traps[rand] = traps[t];
            traps[t] = temp;
            
        }
    }

    public static int[] getTraps()
    {
        return traps;
    }
    
}
