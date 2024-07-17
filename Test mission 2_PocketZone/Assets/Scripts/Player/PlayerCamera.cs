using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _playerTransform;

    private void Start()
    {
        if (_camera == null)
        {
            Debug.LogAssertion("Camera component was null");
        }

        if (_playerTransform == null)
        {
            Debug.LogAssertion("Player's transform component was null");
        }
    }

    private void LateUpdate()
    {
        _camera.transform.position = new Vector3(_playerTransform.position.x, _playerTransform.position.y, _camera.transform.position.z);
    }
}
