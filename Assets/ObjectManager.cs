using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject[] Comida;
    public int currentIndex = -1;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if (currentIndex < Comida.Length)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);
            }
            else
            {
                currentIndex = 0;
                DeactivateAll();
                ActivateByIndex(currentIndex);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex >= 0)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);
            }
            else
            {
                currentIndex = Comida.Length - 1;
                DeactivateAll();
                ActivateByIndex(currentIndex);
            }
        }


    }

    void DeactivateAll()
    {
        for (int i = 0; i < Comida.Length; i++)
        {
            Comida[i].SetActive(false);
        }
    }
    void ActivateByIndex(int index)
    {
        Comida[index].SetActive(true);
    }
}

