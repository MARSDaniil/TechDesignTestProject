using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Counter : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI counterNumText;

    [SerializeField]
    private GameObject increaseSizeBotton;

    private GameObject CatController;
    private CatConrol localCatConrol;
    private void Awake()
    {
        increaseSizeBotton.SetActive(false);
        CatController = GameObject.Find("cats_controller");
        localCatConrol = CatController.GetComponent<CatConrol>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (localCatConrol.countOfClick >= 3)
        {
            Debug.Log("count more 2");
            if (!increaseSizeBotton.activeInHierarchy)
            {
                increaseSizeBotton.SetActive(true);
            }
        }
        else
        {
            if(increaseSizeBotton.activeInHierarchy)
            {
                increaseSizeBotton.SetActive(false);
            }
        }
        counterNumText.text = localCatConrol.countOfClick.ToString();
    }
}
