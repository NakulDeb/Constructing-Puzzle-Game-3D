using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController1 : MonoBehaviour
{
    public GameObject[] b = new GameObject[14];
    public GameObject[] bUse = new GameObject[14];

    Vector3[] bUsePos = new Vector3[14];

    private float secondCounter = 0;


    void Start()
    {
        for (int i = 0; i < 14; i++)
        {
            bUsePos[i] = bUse[i].transform.position;
        }
    }









    void Update()
    {
        secondCounter += Time.deltaTime;
 
        if (secondCounter < 4 && secondCounter > 3)
        {
            bUse[0].transform.position = b[0].transform.position;
        }
        else if (secondCounter < 5 && secondCounter > 4)
        {
            bUse[1].transform.position = b[1].transform.position;
        }
        else if (secondCounter < 6 && secondCounter > 5)
        {
            bUse[2].transform.position = b[2].transform.position;
        }
        else if (secondCounter < 7 && secondCounter > 6)
        {
            bUse[3].transform.position = b[3].transform.position;
        }
        else if (secondCounter < 8 && secondCounter > 7)
        {
            bUse[4].transform.position = b[4].transform.position;
        }
        else if (secondCounter < 9 && secondCounter > 8)
        {
            bUse[5].transform.position = b[5].transform.position;
        }
        else if (secondCounter < 10 && secondCounter > 9)
        {
            bUse[6].transform.position = b[6].transform.position;
        }
        else if (secondCounter < 11 && secondCounter > 10)
        {
            bUse[7].transform.position = b[7].transform.position;
        }
        else if (secondCounter < 12 && secondCounter > 11)
        {
            bUse[8].transform.position = b[8].transform.position;
        }
        else if (secondCounter < 13 && secondCounter > 12)
        {
            bUse[9].transform.position = b[9].transform.position;
        }
        else if (secondCounter < 14 && secondCounter > 13)
        {
            bUse[10].transform.position = b[10].transform.position;
        }
        else if (secondCounter < 15 && secondCounter > 14)
        {
            bUse[11].transform.position = b[11].transform.position;
        }
        else if (secondCounter < 16 && secondCounter > 15)
        {
            bUse[12].transform.position = b[12].transform.position;
        }
        else if (secondCounter < 17 && secondCounter > 16)
        {
            bUse[13].transform.position = b[13].transform.position;
        }
    }

}
