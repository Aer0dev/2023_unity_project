using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightNote : MonoBehaviour
{
    public float noteSpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition += Vector3.down * noteSpeed * Time.deltaTime;
    }
}
