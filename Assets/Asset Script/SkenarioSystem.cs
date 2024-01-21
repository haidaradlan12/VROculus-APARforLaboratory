using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkenarioSystem : MonoBehaviour
{
    public AudioSource audioalarm;
    //jenis apar water, foam, powder, co2
    //skenario 1 = Buku terbakar = water, foam, powder
    public bool Mulai1 = false;
    public GameObject buttonS1;
    public GameObject knopkompor;
    public GameObject Apikompor;
    public GameObject apiBuku, apiBuku2, apiBuku3;
    public GameObject[] Buku;
    public GameObject daun;
    public Material daungosong;
    public Material gosong;
    public GameObject trigger1;
    //skenario 2 = labu gelas jatuh dan membuat api = foam, powder, co2
    public bool Mulai2=false;
    public GameObject objectjatuh;
    public bool hidupkanapi=false;
    public GameObject explosion, api;
    public GameObject gelembung, gelembung2, air, air1;
    public GameObject trigger2;
    //skenario 3 = oven terjadi konsleting listrik = powder, co2;
    public bool Mulai3 = false;
    public GameObject expol, fire;
    public GameObject trigger3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mulai1 == true)
        {
            StartCoroutine(skenario1());
        }
        else
        {
            StopCoroutine(skenario1());
        }

        if (Mulai2 == true)
        {
            StartCoroutine(skenario2());
        }
        else
        {
            StopCoroutine(skenario2());
        }

        if (Mulai3 == true)
        {
            StartCoroutine(skenario3());
        }
        else
        {
            StopCoroutine(skenario3());
        }
    }
    
    IEnumerator skenario1()
    {
        yield return new WaitForSeconds(0);
        knopkompor.transform.localEulerAngles = new Vector3(-38.483f, -21.722f, -57.372f);
        Apikompor.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        apiBuku.SetActive(true);
        yield return new WaitForSeconds(1f);
        apiBuku2.SetActive(true);
        yield return new WaitForSeconds(1f);
        apiBuku3.SetActive(true);
        daun.GetComponent<Renderer>().material = daungosong;
        for (int i=0; i<Buku.Length; i++)
        {
            Buku[i].GetComponent<Renderer>().material = gosong;
        }
        yield return new WaitForSeconds(0.1f);
        trigger1.SetActive(true);
        audioalarm.gameObject.SetActive(true);
        Mulai1 = false;
    }

    IEnumerator skenario2()
    {
        yield return new WaitForSeconds(0);
        objectjatuh.GetComponent<Animator>().Play("Skenario 2B");
        if (hidupkanapi == true)
        {
            explosion.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            api.SetActive(true);
            gelembung.SetActive(false);
            gelembung2.SetActive(false);
            air.SetActive(false);
            air1.SetActive(false);
        }
        else
        {
            yield return new WaitForSeconds(10);
        }
        trigger2.SetActive(true);
        audioalarm.gameObject.SetActive(true);
        Mulai2 = false;
    }

    IEnumerator skenario3()
    {
        yield return new WaitForSeconds(0);
        expol.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        fire.SetActive(true);
        yield return new WaitForSeconds(0.1f);

        trigger3.SetActive(true);
        audioalarm.gameObject.SetActive(true);
        Mulai3 = false;
    }
    
}
