using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public int zRot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ★下記の１行を記載してください。
        transform.Rotate(new Vector3(0, 0,zRot) * Time.deltaTime);
    }
}