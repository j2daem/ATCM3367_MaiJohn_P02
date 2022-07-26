using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour
{
    private string oldTag;

    void ChangeTags(string newTag)
    {
        oldTag = this.gameObject.tag;

        this.gameObject.tag = newTag;
    }
}
