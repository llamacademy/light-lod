using System.Collections.Generic;
using UnityEngine;

namespace LlamAcademy.LightLOD.Demo
{
    public class CameraSwapper : MonoBehaviour
    {
        [SerializeField]
        private List<LightLODCamera> Cameras;

        private int index = 0;

        public void SwapCameras()
        {
            Cameras[index].gameObject.SetActive(false);
            Cameras[index].GetComponent<Camera>().enabled = false;
            index++;
            if (index >= Cameras.Count)
            {
                index = 0;
            }

            Cameras[index].gameObject.SetActive(true);
            Cameras[index].GetComponent<Camera>().enabled = true;
            Cameras[index].Activate();
        }

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.V))
            {
                SwapCameras();
            }
        }
    }

}
