﻿namespace Engine
{
    public class Item
    {
        public Item(int id, string name, string namePlural)
        {
            this.ID = id;
            this.Name = name;
            this.NamePlural = namePlural;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string NamePlural { get; set; }
    }
}