using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalArrow : MonoBehaviour
{
    public GameObject[] shelfs;
    // Start is called before the first frame update
    public float speed;
    public float endX;
    private float nextX;
    void Start()
    {
        shelfs = GameObject.FindGameObjectsWithTag("shelf");
    }

    // Update is called once per frame
    void Update()
    {
        nextX = Mathf.MoveTowards(transform.position.x, endX, speed * Time.deltaTime);
        Vector2 movePosition = new Vector3(nextX, transform.position.y, transform.position.z);
        transform.position = movePosition;
        foreach (GameObject s in shelfs)
        {
            Destroy(gameObject);
        }
    }
}
