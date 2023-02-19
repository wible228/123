using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;


public class NewBehaviourScript : MonoBehaviour
{

    static SerialPort serialPort;


    public GameObject bolt;

    // Start is called before the first frame update
    void Start()
    {
        serialPort = new SerialPort
        {
            PortName = "COM3",
            BaudRate = 9600
        };
        serialPort.Open();
    }
    // Update is called once per frame
    void Update()
    {
            string msg = serialPort.ReadExisting();
            float rot = float.Parse(msg)/-4;
            if (msg != "")
            {
            bolt.transform.rotation = Quaternion.Euler(0, 90, rot);
                    }
        }

    }
