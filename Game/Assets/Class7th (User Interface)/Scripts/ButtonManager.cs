using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Text[] textlist;
    [SerializeField] string[] titlelist;

    private void Start()
    {
        for (int i = 0; i < textlist.Length; i++)
        {
            textlist[i].text = titlelist[i];
        }
    }

    public void Execute()
    {
        Debug.Log("Execute");
    }

    public void Shop()
    {
        Debug.Log("Shop");
    }

    public void Quit()
    {
        Debug.Log("Quit");
    }
}
