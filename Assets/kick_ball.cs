using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick_ball : MonoBehaviour
{
    /*
    35
    -20
    -z
     +x
    */

    private Rigidbody fisica;
    public Vector3 chutar;
    public bool naochutou;
    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
        naochutou = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && naochutou)
        {
            fisica.AddForce(chutar, ForceMode.Impulse);
            naochutou = false;
        }
    }
}
