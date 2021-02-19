
using System.Collections;
using UnityEngine;

namespace PositioningAndFacing
{
    public class Relatives : MonoBehaviour
    {
        public Transform reference;
        public Facing facing_relativeToReference;
        public Facing facing_relativeToWorld;
        public Positioning positioning_relativeToObject;
        [Tooltip("How frequently does this script update")]public float updateTime = 0.01f;
        void Start()
        { 
            StartCoroutine(UpdateRelatives());
        }
        public IEnumerator UpdateRelatives()
        {
            var wait = new WaitForSeconds(updateTime);
            while (true)
            {
                facing_relativeToWorld.SetRelatives(transform);
                facing_relativeToReference.SetRelatives(transform, reference);
                positioning_relativeToObject.SetRelatives(transform, reference);
                yield return wait;
            }
        }
    }
}
