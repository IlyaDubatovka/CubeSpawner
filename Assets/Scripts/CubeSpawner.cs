using UnityEngine;


public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    [SerializeField] private float _coloringDuration;

    private GameObject _cube;

    private Color _finalColor;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _cube = Instantiate(_prefab);

            _cube.transform.position = new Vector3(Random.Range(-15, 15), Random.Range(18, 22), Random.Range(-2, 2));
        }
    }
}