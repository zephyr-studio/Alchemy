using System.Collections.Generic;
using Alchemy.Inspector;
using UnityEngine;

public class StringListTest : MonoBehaviour
{
    [SerializeField] string field;
    [SerializeField, DisableAlchemyEditor] string[] array;
    [SerializeField] List<string> list;
}