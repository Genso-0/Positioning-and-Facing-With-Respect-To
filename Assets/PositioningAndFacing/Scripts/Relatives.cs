
using System.Collections;
using UnityEngine;

namespace PositioningAndFacing
{
    public class Relatives : MonoBehaviour
    {
        public Transform reference;
        public Facing facing_relativeToOther; 
        public Positioning positioning_relativeToOther;
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
                facing_relativeToOther.SetRelatives(transform, reference);
                positioning_relativeToOther.SetRelatives(transform, reference);
                yield return wait;
            }
        }
    }
}
