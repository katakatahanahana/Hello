using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KonnnichihaScript : MonoBehaviour
{
    public GameObject A;
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
        // Debug.Log("こんにちわん");
        this.gameObject.SetActive(false);
        A.SetActive(true);
    }
}
