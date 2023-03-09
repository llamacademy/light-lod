using UnityEngine;

namespace LlamAcademy.LightLOD
{
    [RequireComponent(typeof(Camera))]
    public class LightLODCamera : MonoBehaviour
    {
        public static LightLODCamera Instance
        {
            get;
            private set;
        }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public void Activate()
        {
            Instance = this;
        }
    }
}
