using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpArrowController : MonoBehaviour
{
    public GameObject block;

    public void ShootUp()
    {
        for (int x = -8; x < 9; x += 2)
        {
            Quaternion rot = Quaternion.Euler(0, 0, 90);
            Instantiate(block, new Vector3(x, -12, 0), rot);
        }
    }
}
