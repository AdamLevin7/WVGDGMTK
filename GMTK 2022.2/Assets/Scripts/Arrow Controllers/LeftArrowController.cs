using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrowController : MonoBehaviour
{
    public GameObject block;

    void Start()
    {
        
    }

    public void ShootLeft()
    {
        for (int y = -8; y < 9; y += 2)
        {
            Quaternion rot = Quaternion.Euler(0, 0, 180);
            Instantiate(block, new Vector3(12, y, 0), rot);
        }
    }
}
