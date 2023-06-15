using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KonnnichihaScript : MonoBehaviour
{
    public GameObject A;
    public AudioSource[] audioSource;
  

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hello()
    {
        this.gameObject.SetActive(false);
        A.SetActive(true);
    }

    public void Sound()
    {
        //音を鳴らす
        audioSource[0].Play();
    }
}
