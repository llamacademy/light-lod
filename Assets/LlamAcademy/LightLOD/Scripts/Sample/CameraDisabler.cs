using UnityEngine;

namespace LlamaSoftware.Utilities.LightLODDemo
{
    [RequireComponent(typeof(Camera))]
    public class CameraDisabler : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Camera>().enabled = false;
        }
    }
}
