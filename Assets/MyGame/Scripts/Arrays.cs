using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
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
    [SerializeField]
    string longstring;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }
        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        Debug.Log(array1[0]);
        Debug.Log(array2[0]);
        Debug.Log(array3[0]);
        Debug.Log(array4[0]);
        Debug.Log(arrayColoredImagesRed[0]);

        Debug.Log(array1[array1.Length-1]);
        Debug.Log(array2[array2.Length-1]);
        Debug.Log(array3[array3.Length-1]);
        Debug.Log(array4[array4.Length-1]);
        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length-1]);

        AlleWerte();

        for (int i = 0; i < array3.Length; i++)
        {
            Debug.Log(array3[i]);
        }
        for (int i = 0; i < array1.Length; i++)
        {
            longstring = longstring + array1[i] + " ";
        }
        Debug.Log(longstring);

        array1[3] = 3;
        Debug.Log(array1[3]);

        array2[2] = 203;
        Debug.Log(array2[2]);

        array3[5] = 333;
        Debug.Log(array3[5]);

        array4[2] = "heute";
        Debug.Log(array4[2]);

        arrayColoredImagesRed[3].GetComponent<SpriteRenderer>().color = Color.green;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AlleWerte()
    {
        Debug.Log(array1[0] + " " + array1[1] + " " + array1[2] + " " + array1[3]);
    }

}
