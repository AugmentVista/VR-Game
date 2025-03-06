using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoalVisualizer : MonoBehaviour
{
    private Material material;
    [SerializeField] private Material initalMaterial;
    [SerializeField] private Material scoreMaterial;
    private bool isScoredOn = false;


    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        Debug.Log(material);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isScoredOn)
        {
            return;
        }
        else if (isScoredOn)
        {
            GetComponent<MeshRenderer>().material = scoreMaterial;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Coin"))
        {
            isScoredOn = true;
            Debug.Log($"SCORED material should now be {material}");
        }
    }
}
