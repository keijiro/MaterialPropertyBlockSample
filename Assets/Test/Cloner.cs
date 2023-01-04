using UnityEngine;

public sealed class Cloner : MonoBehaviour
{
    [SerializeField] GameObject _source = null;
    [SerializeField] int _count = 10;
    [SerializeField] float _range = 1;

    void Start()
    {
        for (var i = 0; i < _count; i++)
        {
            var p = Random.insideUnitCircle * _range;
            var r = Random.rotation;
            Instantiate(_source, new Vector3(p.x, 0, p.y), r);
        }
    }
}
