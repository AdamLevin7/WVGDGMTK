using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBombController : MonoBehaviour
{

    public GameObject[] upTables;
    public GameObject[] sideTables;
    public GameObject bomb;

    void Start()
    {
        //RightBombs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RightBombs()
    {
        foreach (GameObject table in upTables)
        {
            Quaternion rot = Quaternion.Euler(0, 0, 0);
            Instantiate(bomb, new Vector3(table.transform.position.x, table.transform.position.y + 1, 0), rot);
            Instantiate(bomb, new Vector3(table.transform.position.x, table.transform.position.y - 1, 0), rot);
        }
        foreach (GameObject table in sideTables)
        {
            Quaternion rot = Quaternion.Euler(0, 0, 0);
            Instantiate(bomb, new Vector3(table.transform.position.x + 1, table.transform.position.y, 0), rot);
        }
    }
}
