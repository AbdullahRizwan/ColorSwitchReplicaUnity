using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDriver : MonoBehaviour
{
    [SerializeField] GameObject[] c;
    [SerializeField] GameObject colorChanger;
    [SerializeField] GameObject bar;

    [SerializeField] Transform prevPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawner()
    {
        int index = Random.Range(0, 5);

        GameObject acirlce = Instantiate(c[index]);
        acirlce.transform.position = new Vector3(0, prevPosition.position.y + 6, 0);

       
        bar.transform.position = colorChanger.transform.position;

        colorChanger.transform.position = new Vector3(0, prevPosition.position.y + 10, 0);
    } 
}
