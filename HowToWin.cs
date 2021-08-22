using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HowToWin : MonoBehaviour
{
    public MeshRenderer kare1, kare2,tebrikyazisi1;
    public GameObject küp1, küp2;
    public TextMeshPro tebrikyazisi;
    private MeshRenderer ressam;
    public Material sari, kirmizi, yesil, mavi, pembe, beyaz;
   

    void Update()
    {

        if ((kare1.material = beyaz) && (kare2.material = beyaz))
        {

            return;
        }






       if(kare1.material.name == kare2.material.name)
        {

             StartCoroutine(deneme());

        }


        
        

    }   
        
    


    IEnumerator deneme()
    {


        küp1.SetActive(false);
        küp2.SetActive(false);
        tebrikyazisi1.enabled = true;

        Debug.Log("tebrikler");
        yield return new WaitForSeconds(3);
        Debug.Log("Coroutine");
        küp1.SetActive(true);
        küp2.SetActive(true);
        tebrikyazisi1.enabled = false;
        Renkver();

    }


    void Renkver()
    {
        int rastgele = Random.Range(1, 7);

        Debug.Log(rastgele);

        switch (rastgele)
        {

            case 1:
                ressam.material = sari;
                break;
            case 2:
                ressam.material = kirmizi;
                break;
            case 3:
                ressam.material = yesil;
                break;
            case 4:
                ressam.material = mavi;
                break;
            case 5:
                ressam.material = pembe;
                break;
        }





    }
}


