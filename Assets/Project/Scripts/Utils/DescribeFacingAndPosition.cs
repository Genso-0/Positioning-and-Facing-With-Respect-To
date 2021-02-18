using RelativesLib; 
using UnityEngine;
using UnityEngine.UI;

public class DescribeFacingAndPosition : MonoBehaviour
{
    Text description;
    Relatives relatives_subject;
    public GameObject targetTransform;
    public GameObject subjectTransform;
    void Start()
    {
        description = GetComponentInChildren<Text>();
        relatives_subject = subjectTransform.GetComponent<Relatives>(); 
    }
     
    void Update()
    {
        description.text = $"Camera is facing {relatives_subject.facing_relativeToWorld.direction} relative to world\n" +
            $"Camera is facing {relatives_subject.facing_relativeToReference.direction} relative to Suzanne\n"+
            $"Camera is positioned {relatives_subject.positioning_relativeToObject.direction} relative to Suzanne";
    }
}
