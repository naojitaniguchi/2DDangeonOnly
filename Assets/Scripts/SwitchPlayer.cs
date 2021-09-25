using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{
    public float[] walkSpeed ;
    GameObject activePlayer = null;
    int activeIndex = 0;



    // Start is called before the first frame update
    void Start()
    {
        if ( gameObject.transform.childCount > 0)
        {
            activePlayer = gameObject.transform.GetChild(0).gameObject;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.left * walkSpeed[activeIndex];
            if (gameObject.transform.localScale.x >= 0.0f)
            {
                gameObject.transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            }
            if ( activePlayer != null)
            {
                activePlayer.GetComponent<Animator>().SetTrigger("Run");
            }
            
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * walkSpeed[activeIndex];
            if (gameObject.transform.localScale.x <= 0.0f)
            {
                gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (activePlayer != null)
            {
                activePlayer.GetComponent<Animator>().SetTrigger("Run");
            }
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * walkSpeed[activeIndex];
            if (activePlayer != null)
            {
                activePlayer.GetComponent<Animator>().SetTrigger("Run");
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.down * walkSpeed[activeIndex];
            if (activePlayer != null)
            {
                activePlayer.GetComponent<Animator>().SetTrigger("Run");
            }
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            if (activePlayer != null)
            {
                activePlayer.GetComponent<Animator>().SetTrigger("Idle");
            }
        }   
    }
    public void SwitchCharactor()
    {
        activePlayer.SetActive(false);
        activeIndex++;

        if ( activeIndex >= gameObject.transform.childCount)
        {
            activeIndex = 0;
        }
        activePlayer = gameObject.transform.GetChild(activeIndex).gameObject;
        activePlayer.SetActive(true);

    }
}
