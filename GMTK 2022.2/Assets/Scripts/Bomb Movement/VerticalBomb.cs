using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBomb : MonoBehaviour
{

    public float speed;
    public float direction;
    private float endY;
    private float nextY;
    private int counter;
    
    void Start()
    {
        endY = transform.position.y + direction;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nextY = Mathf.MoveTowards(transform.position.y, endY, speed * Time.deltaTime);
        Vector2 movePosition = new Vector3(transform.position.x, nextY, transform.position.z);
        transform.position = movePosition;
        Destroy(gameObject, 0.95f);
    }

    void FixedUpdate()
    {
        GetComponent<Collider2D>().enabled = false;
        counter++;
        if (counter >= 28)
        {
            GetComponent<Collider2D>().enabled = true;
        }
    }
}
