using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sections;
    public float zPosition = 30.5f;
    public bool creatingSection = false;
    public int sectionNum;

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;

            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        sectionNum = Random.Range(0, 3);

        GameObject newSection = Instantiate(sections[sectionNum], new Vector3(0, 0, zPosition), Quaternion.identity);
        newSection.transform.localScale = new Vector3(1, 1, 1);
        newSection.transform.position = new Vector3(0, 0, newSection.transform.position.z);

        zPosition += 30.5f;

        yield return new WaitForSeconds(4);

        creatingSection = false;
    }
}
