using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    int[] array;
    [SerializeField]
    int[] array1 = {1, 2, 3, 4};
    [SerializeField]
    int[] array2 = {21, 22, 23, 24};
    [SerializeField]
    int[] array3 = {31, 32, 33, 34, 35, 36, 37};
    [SerializeField]
    string[] array4 = new string[10];
    [SerializeField]
    GameObject[] arrayColoredImagesRed;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }
        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
