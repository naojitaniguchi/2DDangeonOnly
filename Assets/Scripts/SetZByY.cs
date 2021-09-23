using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetZByY : MonoBehaviour
{
    // Start is called before the first frame update
    public float yMin = -5.0f;
    public float yMax = 5.0f;
    public float ZMin = 0.0f;
    public float ZMax = 10.0f;
    public bool StaticMode = true;

    void Start()
    {
        calcZFromY();
    }

    // Update is called once per frame
    void Update()
    {
        if ( StaticMode)
        {
            return;
        }

        calcZFromY();
    }

    void calcZFromY()
    {
        float yLength = yMax - yMin;
        float y = gameObject.transform.position.y - yMin;
        y /= yLength;

        float z = ZMin + y * (ZMax - ZMin);

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, z);
    }
}
