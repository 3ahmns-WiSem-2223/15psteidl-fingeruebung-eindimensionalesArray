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
    [SerializeField]
    int[] array5 = new int[25];
    int a = 20;
    [SerializeField]
    int[] array6 = new int[250];
    [SerializeField]
    int[] array7 = new int[250];
    int bruh = 1;
    [SerializeField]
    string[] array8 = new string[100];
    [SerializeField]
    float[] array9 = new float[1000];
    [SerializeField]
    int[] array10;
    [SerializeField]
    int[] array11 = new int[1000];

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

        for (int i = 0; i < array5.Length; i++)
        {
            a = a + 2;
            array5[i] = a;
        }

        for (int i = 0; i < array6.Length; i++)
        {
            array6[i] = i * 2;
        }

        for (int i = 0; i < array7.Length; i++)
        {
            array7[i] = bruh;
            bruh = bruh + 2;
        }

        for (int i = 0; i < array8.Length;)
        {
            array8[i] = "a";
            i = i + 2;
        }

        for (int brah = 1; brah < array8.Length;)
        {
            array8[brah] = "b";
            brah = brah + 2;
        }

        for (int i = 0; i < array9.Length; i++)
        {
            array9[i] = UnityEngine.Random.Range(0f, 100f);
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

        System.Array.Sort(array9);
        for (int i = 0; i < array9.Length; i++)
        {
            Debug.Log(array9[i]);
        }

        for (int i = 0; i < array11.Length; i++)
        {
            array11[i] = UnityEngine.Random.Range(0, 100000);
        }

        System.Array.Sort(array11);

        Debug.Log(array11[0]);
        Debug.Log(array11[array11.Length -1]);
        

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
