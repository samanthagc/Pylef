using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeslocamentoBG : MonoBehaviour
{   
    private Renderer objectRender;
    private Material objectMaterial;
    public float offset;
    public float offsetIncrement;
    public float offsetVelocity;

    public string sortingLayer;
    public int orderinLayer;

    // Start is called before the first frame update
    void Start()
    {

        
        objectRender = GetComponent<MeshRenderer>();

        objectRender.sortingLayerName = sortingLayer;
        objectRender.sortingOrder = orderinLayer;

        objectMaterial = objectRender.material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += offsetIncrement;
        objectMaterial.SetTextureOffset("_MainTex", new Vector2(offset * offsetVelocity, 0));
    }
}
