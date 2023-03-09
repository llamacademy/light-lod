using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace LlamAcademy.LightLOD
{
    [RequireComponent(typeof(Light))]
    public class LightLOD : MonoBehaviour
    {
        private Light Light;
        public bool LightShouldBeOn = true;
        [SerializeField]
        [Range(0, 1)]
        private float UpdateDelay = 0.1f;
        [SerializeField]
        private List<LODAdjustment> LODLevels = new();

        private void Awake()
        {
            Light = GetComponent<Light>();
        }

        private void OnEnable()
        {
            StartCoroutine(AdjustLODQuality());
        }

        private IEnumerator AdjustLODQuality()
        {
            float delay = UpdateDelay + UpdateDelay == 0 ? UpdateDelay : UnityEngine.Random.value / 20f;
            WaitForSeconds wait = new(delay);

            while (true)
            {
                if (LightLODCamera.Instance == null)
                {
                    yield return wait;
                    continue;
                }

                if (LightShouldBeOn)
                {
                    float squareDistanceFromCamera = Vector3.SqrMagnitude(
                        LightLODCamera.Instance.transform.position - transform.position
                    );

                    for (int i = 0; i < LODLevels.Count; i++)
                    {
                        if (i == LODLevels.Count - 1 || (
                            squareDistanceFromCamera > LODLevels[i].MinSquareDistance
                            && squareDistanceFromCamera <= LODLevels[i].MaxSquareDistance
                        ))
                        {
                            Light.enabled = true;
                            Light.shadows = LODLevels[i].LightShadows;
                            if (QualitySettings.shadowResolution <= LODLevels[i].ShadowResolution)
                            {
                                Light.shadowResolution = (LightShadowResolution)QualitySettings.shadowResolution;
                            }
                            else
                            {
                                Light.shadowResolution = (LightShadowResolution)LODLevels[i].ShadowResolution;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    Light.enabled = false;
                }

                yield return wait;
            }
        }
    }
}
