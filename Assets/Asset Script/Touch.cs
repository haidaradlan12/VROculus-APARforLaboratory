using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public int jenis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            if (jenis == 1)
            {
                FindObjectOfType<SkenarioSystem>().Mulai1 = true;
            }
            if (jenis == 2)
            {
                FindObjectOfType<SkenarioSystem>().Mulai2 = true;
            }
            if (jenis == 3)
            {
                FindObjectOfType<SkenarioSystem>().Mulai3 = true;
            }
        }
    }
}
