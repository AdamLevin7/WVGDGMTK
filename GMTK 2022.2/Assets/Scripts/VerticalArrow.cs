using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalArrow : MonoBehaviour
{
    public GameObject[] shelfs;
    // Start is called before the first frame update
    public float speed;
    public float endY;
    private float nextY;
    void Start()
    {
        shelfs = GameObject.FindGameObjectsWithTag("shelf");
    }

    // Update is called once per frame
    void Update()
    {
        nextY = Mathf.MoveTowards(transform.position.y, endY, speed * Time.deltaTime);
        Vector2 movePosition = new Vector3(transform.position.x, nextY, transform.position.z);
        transform.position = movePosition;
        foreach (GameObject s in shelfs)
        {
            Destroy(gameObject);
        }
    }
}
