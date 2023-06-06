using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatConrol : MonoBehaviour
{
    public GameObject buttonOn;

    private GameObject catToAnimGameObject;

    private string colliderTag;
    Ray ray = new Ray();
    private void Start()
    {
        //    boxCollider2D = GetComponent<BoxCollider2D>();
        if(buttonOn != null)
        {
            buttonOn.SetActive(false);
        }
     
    }

    private void Update()
    {
        RayCast();
    }

    private void RayCast()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(new Vector3(0, 0, -10), Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                Debug.Log("U enter to raycast");

                colliderTag = hitInfo.collider.tag;

                if (colliderTag == null)
                {
                    Debug.Log("Collider is null");
                }
                else
                {
                    Debug.Log("colliderTag = " + colliderTag);

                }

                SelectTag(colliderTag, hitInfo);
            }
        }
    }

    private void SelectTag(string colliderTag, RaycastHit hitInfo)
    {
        getGameObjectComponent(hitInfo);
        switch (colliderTag)
        {
            case "cat_always_anim":
                Debug.Log("U touch always anim");
                PlaySound();
                return;
            case "cat_to_start_anim":
                Debug.Log("U touch cat_to_start_anim");
                PlaySound();
                setActiveAnim(hitInfo);
                
                return;
            case "cat_to_open_botton":
                PlaySound();
                SetActiveBotton();
                
                return;
        }
    }

    private void getGameObjectComponent(RaycastHit hitInfo)
    {
        catToAnimGameObject = hitInfo.transform.gameObject;
        Debug.Log("U try to get component");
        if (catToAnimGameObject == null)
        {
            Debug.Log("catToAnimGameObject == null");
        }
     
    }

    private void PlaySound()
    {
        if (catToAnimGameObject != null)
        {
            AudioClick audioClick = catToAnimGameObject.GetComponent<AudioClick>();
            audioClick.ClickSound();
        }
        
    }

    private void setActiveAnim(RaycastHit hitInfo)
    {
        
        
        Debug.Log("U try to get Animation");

        Animator animCatToStart = catToAnimGameObject.GetComponent<Animator>();

        if (animCatToStart == null)
        {
                Debug.Log("animCatToStart == null");
        }
        else
        {
                animCatToStart.enabled = true;
        }

        
    }


    private void SetActiveBotton()
    {
        if (buttonOn != null)
        {
            buttonOn.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("buttonOn = 0");
        }

    }
    
}
