using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBehabior : MonoBehaviour
{
    public Animator topAni;
    public GameObject cav;
    bool clicked = false;
    public AudioSource audio;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                string name = hitInfo.collider.gameObject.name;

               
                if (name == "top" && !clicked)
                {
                    clicked = true;
                    topAni.Play("top");
                    Invoke("DisableObj",1);
                    
                    audio.Play();
                }

              
            }
        }
    }

    private void DisableObj()
    {
        topAni.gameObject.SetActive(false);
        cav.SetActive(true);
    }
}
