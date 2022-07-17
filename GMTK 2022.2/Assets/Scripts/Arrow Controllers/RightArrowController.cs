using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrowController : MonoBehaviour
{

    public GameObject block;

    public void ShootRight()
    {
        for (int y = -8; y < 9; y += 2)
        {
            Quaternion rot = Quaternion.Euler(0, 0, 0);
            Instantiate(block, new Vector3(-12, y, 0), rot);
        }
    }
}
