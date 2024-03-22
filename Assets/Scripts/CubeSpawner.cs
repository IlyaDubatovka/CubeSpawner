
using UnityEngine;
using Random = UnityEngine.Random;


public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    [SerializeField] private float _cubesRecoloringDuration;
    [SerializeField] private float _cubesDelayDuration;
    private GameObject _cube;

    private Color _finalColor;

    private void Start()
    {
        _prefab.GetComponent<RecoloringManager>().recoloringDuration = _cubesRecoloringDuration;
        _prefab.GetComponent<RecoloringManager>().delayDuration = _cubesDelayDuration;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _cube = Instantiate(_prefab);

            _cube.transform.position = new Vector3(Random.Range(-15, 15), Random.Range(18, 22), Random.Range(-2, 2));
        }
    }
}