using System.Collections.Generic;
using UnityEngine;

namespace WorldQuest
{
    public struct WorldQuestDescriptor
    {
        public string name;
        public string description;
    }

    public class PlayerWorldQuests : MonoBehaviour
    {
        public List<Manager> managers = new List<Manager>();

        public bool participating => managers.Count > 0;

        public void Register(Manager manager)
        {
            managers.Add(manager);
        }

        public void Unregister(Manager manager)
        {
            managers.Remove(manager);
        }
    }
}