using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    public GameObject[] obj;
    public GameObject oyunPanel;

    void Start()
    {
        Clone();
    }

    void Clone()
    {
        
        
            Instantiate(obj[Random.Range(0,
                obj.Length)], this.gameObject.transform.position, Quaternion.identity);

            Invoke("Clone", 3);
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}