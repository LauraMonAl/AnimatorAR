using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeerDatos : MonoBehaviour {
	private string leerpotenciometros = "http://tadeolabhack.com:8081/test/animacion/leerdb.php";
    public Window_Graph WG;

	public Text[] poses = new Text[10];
	int [] PosesAnimacion= new int[10];
    string[] PosesAr;
	// Use this for initialization
	void Start () {
        //corrutina obtiene un valor del id que este en las comillas
        StartCoroutine(datos("5"));

        for (int i=0; i<PosesAnimacion.Length; i++){
			Debug.Log ("Valor Potenciometro2" +i+ "es"+PosesAnimacion[i]);
            poses[i].text = PosesAnimacion[i].ToString();
        }
	}

public void LlamarDatos() {

        StartCoroutine(datos("5"));

    }

    // Update is called once per frame
    IEnumerator datos(string id) {

		yield return new WaitForSeconds(1);


		string posesanim = leerpotenciometros + "?UserId=" + id;
		WWW ptn = new WWW(posesanim);
		yield return ptn;

		if (!string.IsNullOrEmpty(ptn.text))
		{
            //trim le quita los espacios al comienzo y al final
            PosesAr = ptn.text.Split(char.Parse(" "));
            Debug.Log("Valor Potenciometro" + "es" + ptn.text);

            for (int i = 0; i < PosesAr.Length; i++)
            {

                Debug.Log("Valor Potenciometro" + i + "es" + PosesAr[i]);
                poses[i].text = PosesAr[i];
            }
        }
        WG.ShowData();
	}
}
