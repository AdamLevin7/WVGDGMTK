using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalBomb : MonoBehaviour
{

    public float speed;
    public float direction;
    private float endX;
    private float nextX;
    private int counter;

    void Start()
    {
        endX = transform.position.x + direction;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nextX = Mathf.MoveTowards(transform.position.x, endX, speed * Time.deltaTime);
        Vector2 movePosition = new Vector3(nextX, transform.position.y, transform.position.z);
        transform.position = movePosition;
        Destroy(gameObject, 1);
    }

    void FixedUpdate()
    {
        GetComponent<Collider2D>().enabled = false;
        counter++;
        if(counter >= 28)
        {
            GetComponent<Collider2D>().enabled = true;
        }
    }
}
