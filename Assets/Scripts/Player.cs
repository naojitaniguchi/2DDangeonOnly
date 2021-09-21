using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float walkSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.left * walkSpeed;
            if (gameObject.transform.localScale.x >= 0.0f)
            {
                gameObject.transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            }
            gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * walkSpeed;
            if (gameObject.transform.localScale.x <= 0.0f)
            {
                gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * walkSpeed;
            gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.down * walkSpeed;
            gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            gameObject.GetComponent<Animator>().SetTrigger("Idle");
        }
    }
}
