﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location (int id,string name, string description, Item itemrequiredtoenter=null, Quest questavailablehere = null, Monster monsterlivinghere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemrequiredtoenter;
            QuestAvailableHere = questavailablehere;
            MonsterLivingHere = monsterlivinghere;
        }
    }
}
