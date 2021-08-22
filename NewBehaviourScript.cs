using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private MeshRenderer ressam;
    public Material sari, kirmizi, yesil, mavi, pembe, beyaz;
    void Start()
    {
        ressam = GetComponent<MeshRenderer>();
    }

    void Uptade()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Renkver();
        }
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