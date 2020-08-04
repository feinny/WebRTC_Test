using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class keyEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent UnityEvent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("sssssss");
            UnityEvent?.Invoke();
        }
    }
}
