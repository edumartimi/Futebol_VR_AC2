using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody fisica;
    public int forca;
    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            fisica.AddForce(Vector3.up * forca, ForceMode.Impulse);
        }
        if(Input.GetKey(KeyCode.Mouse1))
        {
            Time.timeScale = 0.5f;
        }
    }
}
