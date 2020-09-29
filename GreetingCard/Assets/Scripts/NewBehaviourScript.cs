using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private int a = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("Awake");
    }
    void Start()
    {
        Debug.Log("Start");
    }
 
    // Update is called once per frame
    void Update()
    {
        Debug.Log(a);
        transform.Rotate(0, 1 * Time.deltaTime, 0);
    }
}
