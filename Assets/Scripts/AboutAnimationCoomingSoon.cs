using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutAnimationCoomingSoon : MonoBehaviour
{
    public GameObject objek;
    Transform cachedTransform;
    int levelindex;
    // Start is called before the first frame update
    void Start()
    {
        cachedTransform = transform;

        levelindex = 0;

    }
    // Update is called once per frame
    void Update()
    {
        if (cachedTransform.position.y >= 2300)
        {
            SceneManager.LoadScene(levelindex); 
        }
    }
    
}
