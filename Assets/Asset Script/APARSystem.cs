using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class APARSystem : MonoBehaviour
{
    public bool handRight;
    public GameObject handright, handleft;
    public Image back1, back2;
    public TMP_Text textfinish;
    public GameObject canvasnya;
    public AudioSource alrm;
    public int jumlahapi;
    public GameObject[] api1;
    public GameObject[] api2;
    public GameObject[] api3;
    public GameObject moncong;
    public GameObject isi;
    public int jenis;
    public int skenario;
    public bool mulai = false;
    public bool onetouch=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumlahapi = GameObject.FindGameObjectsWithTag("API").Length;
        if (GetComponent<Rigidbody>().isKinematic == true)
        {
            GetComponent<Rigidbody>().useGravity = true;
            if (handRight == true)
            {
                this.transform.rotation = handright.transform.rotation;
                this.transform.position = handright.transform.position;
            }
            else
            {
                this.transform.rotation = handleft.transform.rotation;
                this.transform.position = handleft.transform.position;
            }
            //this.transform.localPosition = new Vector3(0, 0, 0);
            onetouch = false;
        }
        else
        {
            if (onetouch == true)
            {
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<Rigidbody>().freezeRotation = true;
            }
            else
            {
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Rigidbody>().freezeRotation = false;
            }
            
        }
        
        if (mulai == true)
        {
            if (jenis == 1)
            {
                //bisa skenario 1
                if (skenario == 1)
                {
                    StartCoroutine(skenario1benar());   
                }
                //tidak bisa skenario 2 3
                else if (skenario == 2)
                {
                    StartCoroutine(skenario2salah());
                }
                else if (skenario == 3)
                {
                    StartCoroutine(skenario3salah());
                }
            }
            else if (jenis == 2)
            {
                //bisa skenario 1 dan 2
                if (skenario == 1)
                {
                    StartCoroutine(skenario1benar());
                }
                else if (skenario == 2)
                {
                    StartCoroutine(skenario2benar());
                }
                //tidak bisa skenario 3
                else if (skenario == 3)
                {
                    StartCoroutine(skenario3salah());
                }
            }
            else if (jenis == 3)
            {
                //bisa skenario 1 2 3
                if (skenario == 1)
                {
                    StartCoroutine(skenario1benar());
                }
                else if (skenario == 2)
                {
                    StartCoroutine(skenario2benar());
                }
                else if (skenario == 3)
                {
                    StartCoroutine(skenario3benar());
                }
            }
            else if (jenis == 4)
            {
                //bisa sekenario 2 3
                if (skenario == 2)
                {
                    StartCoroutine(skenario2benar());
                }
                else if (skenario == 3)
                {
                    StartCoroutine(skenario3benar());
                }
                //tidak bisa skenario 1
                else if (skenario == 1)
                {
                    StartCoroutine(skenario1salah());
                }
            }
        }
        else
        {
            canvasnya.SetActive(true);
            StopAllCoroutines();
            isi.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "skenario1")
        {
            skenario = 1;
        }
        if (other.gameObject.tag == "skenario2")
        {
            skenario = 2;
        }
        if (other.gameObject.tag == "skenario3")
        {
            skenario = 3;
        }
        //
        if (other.gameObject.name == "CustomHandLeft")
        {
            handRight = false;
        }
        if (other.gameObject.name == "CustomHandRight")
        {
            handRight = true;
        }
    }
    IEnumerator skenario1benar()
    {
        yield return new WaitForSeconds(0f);
        //
        moncong.transform.LookAt(api1[0].transform);
        isi.SetActive(true);
        yield return new WaitForSeconds(3f);
        api1[0].SetActive(false);
        Destroy(api1[0]);
        yield return new WaitForSeconds(0.1f);
        //
        moncong.transform.LookAt(api1[1].transform);
        isi.SetActive(true);
        yield return new WaitForSeconds(3f);
        api1[1].SetActive(false);
        Destroy(api1[1]);
        yield return new WaitForSeconds(0.1f);
        //
        moncong.transform.LookAt(api1[2].transform);
        isi.SetActive(true);
        yield return new WaitForSeconds(3f);
        api1[2].SetActive(false);
        Destroy(api1[2]);
        yield return new WaitForSeconds(0.1f);
        //
        moncong.transform.LookAt(api1[3].transform);
        isi.SetActive(true);
        yield return new WaitForSeconds(3f);
        api1[3].SetActive(false);
        Destroy(api1[3]);
        yield return new WaitForSeconds(0.1f);
        if (jumlahapi == 0)
        {
            textfinish.text = "Mission Complete!!";
            alrm.gameObject.SetActive(false);
            back1.GetComponent<Image>().color = Color.green;
            back2.GetComponent<Image>().color = Color.green;
            mulai = false;
        }
    }
    IEnumerator skenario2benar()
    {
        yield return new WaitForSeconds(0f);
        moncong.transform.LookAt(api2[0].transform);
        isi.SetActive(true);
        yield return new WaitForSeconds(3f);
        api2[0].SetActive(false);
        api2[1].SetActive(false);
        Destroy(api2[0]);
        Destroy(api2[1]);
        yield return new WaitForSeconds(0.1f);
        if (jumlahapi == 0)
        {
            textfinish.text = "Mission Complete!!";
            alrm.gameObject.SetActive(false);
            back1.GetComponent<Image>().color = Color.green;
            back2.GetComponent<Image>().color = Color.green;
            mulai = false;
        }
    }
    IEnumerator skenario3benar()
    {
        yield return new WaitForSeconds(0f);
        moncong.transform.LookAt(api3[0].transform);
        isi.SetActive(true);
        yield return new WaitForSeconds(3f);
        api3[0].SetActive(false);
        Destroy(api3[0]);
        yield return new WaitForSeconds(0.1f);
        if (jumlahapi==0)
        {
            textfinish.text = "Mission Complete!!";
            alrm.gameObject.SetActive(false);
            back1.GetComponent<Image>().color = Color.green;
            back2.GetComponent<Image>().color = Color.green;
            mulai = false;
        }
    }
    IEnumerator skenario1salah()
    {
        yield return new WaitForSeconds(0f);
        moncong.transform.LookAt(api1[0].transform);
        isi.SetActive(true);
        yield return new WaitForSeconds(5f);
        api1[0].transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        api1[1].transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        api1[2].transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        api1[3].transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        yield return new WaitForSeconds(0.1f);
        textfinish.text = "Mission Failed!!";
        back1.GetComponent<Image>().color = Color.red;
        back2.GetComponent<Image>().color = Color.red;
        mulai = false;
    }
    IEnumerator skenario2salah()
    {
        yield return new WaitForSeconds(0f);
        moncong.transform.LookAt(api2[0].transform);
        isi.SetActive(true);
        yield return new WaitForSeconds(5f);
        api2[0].transform.localScale = new Vector3(6f, 6f, 6f);
        yield return new WaitForSeconds(0.1f);
        textfinish.text = "Mission Failed!!";
        back1.GetComponent<Image>().color = Color.red;
        back2.GetComponent<Image>().color = Color.red;
        mulai = false;

    }
    IEnumerator skenario3salah()
    {
        yield return new WaitForSeconds(0f);
        moncong.transform.LookAt(api3[0].transform);
        isi.SetActive(true);
        yield return new WaitForSeconds(5f);
        api3[0].transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        yield return new WaitForSeconds(0.1f);
        textfinish.text = "Mission Failed!!";
        back1.GetComponent<Image>().color = Color.red;
        back2.GetComponent<Image>().color = Color.red;
        mulai = false;
    }
}
