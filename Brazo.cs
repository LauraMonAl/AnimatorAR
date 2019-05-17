using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Brazo : MonoBehaviour {


	SerialPort puerto = new SerialPort("COM5",9600);


	// Use this for initialization
	void Start () {

		puerto.Open();
		puerto.ReadTimeout = 1;
		
	}
	
	// Update is called once per frame
	void Update () {


		if (puerto.IsOpen)
		{
			try {

				string datosCadena = puerto.ReadLine();
				string [] datos = datosCadena.Split('T');
				for (int i=0; i < datos.Length; i++){
					Debug.Log (datos[0]+datos[1]+datos[2] + datos[3] + datos[4] + datos[5] + datos[6] + datos[7] + datos[8]);
				}
                

				GameObject.FindGameObjectWithTag("BrazoDer").transform.rotation =Quaternion.Euler (0, 0,int.Parse(datos[0]));
				GameObject.FindGameObjectWithTag("CodoDer").transform.rotation =Quaternion.Euler (0, 0, int.Parse(datos[1]));
				GameObject.FindGameObjectWithTag("BrazoIzq").transform.rotation =Quaternion.Euler (0, 0, int.Parse(datos[2]));
                GameObject.FindGameObjectWithTag("CodoIzq").transform.rotation = Quaternion.Euler(0, 0, int.Parse(datos[3]));
                GameObject.FindGameObjectWithTag("PiernaDer").transform.rotation = Quaternion.Euler(0, 0, int.Parse(datos[4]));
                GameObject.FindGameObjectWithTag("RodillaDer").transform.rotation = Quaternion.Euler(0, 0, int.Parse(datos[5]));
                GameObject.FindGameObjectWithTag("PiernaIzq").transform.rotation = Quaternion.Euler(0, 0, int.Parse(datos[6]));
                GameObject.FindGameObjectWithTag("RodillaIzq").transform.rotation = Quaternion.Euler(0, 0, int.Parse(datos[7]));
               // GameObject.FindGameObjectWithTag("Cabeza").transform.position  = new Vector3 (0,int.Parse(datos[8]));
                

            }

			catch (System.Exception){ 


			}
		}
		
	}

	

}
