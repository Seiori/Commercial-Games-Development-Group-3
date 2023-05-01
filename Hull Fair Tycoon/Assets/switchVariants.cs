using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchVariants : MonoBehaviour
{
    public GameObject animated;
    public GameObject nonanimated;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)) 
        {
            animated.SetActive(!animated.activeSelf);
            nonanimated.SetActive(!nonanimated.activeSelf);
        }
    }
}
