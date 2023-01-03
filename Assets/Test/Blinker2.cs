using UnityEngine;

public class Blinker2 : MonoBehaviour
{
    MaterialPropertyBlock _block;

    void Start()
      => _block = new MaterialPropertyBlock();

    void Update()
    {
        var color = Color.Lerp(Color.red, Color.blue, (Mathf.Sin(Time.time) + 1) / 2);
        _block.SetColor("_BaseColor", color);

        var renderer = GetComponent<Renderer>();
        renderer.SetPropertyBlock(_block);
    }
}
