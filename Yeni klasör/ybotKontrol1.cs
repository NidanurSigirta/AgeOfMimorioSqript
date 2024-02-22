using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ybotKontrol : MonoBehaviour
{
    Animator ybotAnim;
    float maxspeed;
    float axisZ;
    float axisX;
    void Start()
    {
        ybotAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // ybotAnim.SetFloat("Hiz",0.4f);
            maxspeed = 0.4f;
            axisZ = maxspeed * Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
            {
                //ybotAnim.SetFloat("Hiz", 1f);
                maxspeed = 1f;
                axisX = maxspeed * Input.GetAxis("Vertical");
            }

        }
        else if (Input.GetKey(KeyCode.Q))
        {
            // ybotAnim.SetFloat("Hiz", 2f);
            maxspeed = 2f;
            axisZ = maxspeed * Input.GetAxis("Horizontal");

        }
        else
        {
            //ybotAnim.SetFloat("Hiz", 0f);
            maxspeed = 0f;
            axisZ = maxspeed * Input.GetAxis("Vertical");
        }
        Vector3 vector = new Vector3(0f, 0f, axisZ);

        ybotAnim.SetFloat("Hiz", Vector3.ClampMagnitude(vector, 2f).magnitude, 2f, Time.deltaTime * 3f);

        ybotAnim.SetFloat("Hiz", maxspeed);


    }
}