using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;

    int step = 0;
    void Start()
    {

    }
    void Update()
    {
        Debug.Log(step);
        if (step == 1)
        {
            if (player.transform.position.x <= -2f)
            {
                step = 0;
            }
            else
            {
                player.transform.position -= new Vector3(3 * Time.deltaTime, 0, 0);
            }
        }

        if (step == 2)
        {
            if (player.transform.position.x >= 2f)
            {
                step = 0;
            }
            else
            {
                player.transform.position += new Vector3(3 * Time.deltaTime, 0, 0);
            }
        }

        if (step == 3)
        {
            if (player.transform.position.y >= 3f)
            {
                step = 0;
            }
            else
            {
                player.transform.position += new Vector3(0, 3 * Time.deltaTime, 0);
            }
        }

        if (step == 4)
        {
            if (player.transform.position.y <= -2f)
            {
                step = 0;
            }
            else
            {
                player.transform.position -= new Vector3(0, 3 * Time.deltaTime, 0);
            }
        }

        if (player.transform.position.y >= 3f && step != 0)
        {
            step = 0;
        }
    }
    public void LeftMove()
    {
        step = 1;
    }

    public void RightMove()
    {
        step = 2;
    }

    public void UpMove()
    {
        if (player.transform.position.y < 3f)
        {
            step = 3;
        }
        
    }

    public void DownMove()
    {
        step = 4;
    }
}