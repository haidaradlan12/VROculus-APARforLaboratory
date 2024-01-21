using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public GameObject canvass;
    public bool Hide = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Hide == true)
        {
            StartCoroutine(hide());
        }
        else
        {
            StopCoroutine(hide());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hand")
        {
            SceneManager.LoadScene("VR Lab 1");
        }
    }

    IEnumerator hide()
    {
        canvass.SetActive(false);
        yield return new WaitForSeconds(60);
        canvass.SetActive(true);
        Hide = false;
    }
}
