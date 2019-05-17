using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;



public class Movimiento : MonoBehaviour
{
    public float vel;

    private float distanciaMov;

    public string portName;
	public Animator Anim;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	int contador;

     SerialPort puerto = new SerialPort("COM4",9600);
     //   SerialPort puerto = new SerialPort("/dev/cu.usbmodem1461",9600);

    // Start is called before the first frame update
    void Start()
    {
        puerto.Open();
        puerto.ReadTimeout = 1;

    }

    // Update is called once per frame
    void Update()
    {
        distanciaMov = vel * Time.deltaTime;

        if (puerto.IsOpen)
        {
            try {
                mover(puerto.ReadByte());
                print(puerto.ReadByte());
                    
              }

            catch (System.Exception){ 


            }
        }
    }

    void  mover (int direccion) { 
		if (direccion == 1) {

			contador++;

		}
		if (direccion == 2) {

			transform.Translate (Vector3.right * distanciaMov, Space.World);
		}
		if (contador == 1) {
			Anim.SetBool ("pose1", true);
		} 
		if (contador == 2) {
			Anim.SetBool ("pose2", true);
		} 
		if (contador == 3) {
			Anim.SetBool ("pose3", true);
		}

		if (contador == 4) {
			Anim.SetBool ("pose4", true);
		} 


		if (contador == 5) {
		
			contador = 0;
		}

	}
}


