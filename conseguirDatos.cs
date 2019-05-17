using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class conseguirDatos : MonoBehaviour
{

    private string urlrecibir = "http://tadeolabhack.com:8081/test/animacion/conseguirId.php";


    public Text poten1;
    public Text poten2;
    public Text poten3;
    public Text poten4;
    public Text poten5;
    public Text poten6;
    public Text poten7;
    public Text poten8;
    public Text poten9;

    // Start is called before the first frame update
    public void ConseguirDatos()
    {
        StartCoroutine(datos("1"));
    }

    public IEnumerator datos(string id)
    {
        yield return new WaitForSeconds(3);


        string primerdato = urlrecibir + "?UserID=" + id;
        WWW poten = new WWW(primerdato);
        yield return poten;

        if (!string.IsNullOrEmpty(poten.text))
        {
            //trim le quita los espacios al comienzo y al final
            poten1.text = poten1.text.Trim();
        }


    }



}
