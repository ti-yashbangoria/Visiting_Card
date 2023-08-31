using UnityEngine;

public class DeleteInBuild : MonoBehaviour
{
    private void Awake()
    {
#if !UNITY_EDITOR
        Destroy(gameObject);
#endif
    }
}