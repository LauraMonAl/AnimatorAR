using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ToArduino : MonoBehaviour
{
	SerialPort puerto = new SerialPort ("COM4",9600);
    // SerialPort puerto = new SerialPort("/dev/cu.usbmodem1461", 9600);

    // Start is called before the first frame update
    void Start()
    {
        puerto.Open();
    }

    // Update is called once per frame
    void Update()
    {
        puerto.Write("1");
        
    }
}
