using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchsken2 : MonoBehaviour
{
    public GameObject objectsentuh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void kenabenda()
    {
        objectsentuh.GetComponent<Animator>().Play("Skenario 2A");
        kirimperintah();
    }
    public void kirimperintah()
    {
        FindObjectOfType<SkenarioSystem>().hidupkanapi = true;
    }
}
