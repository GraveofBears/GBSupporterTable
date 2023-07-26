using System;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
using ServerSync;
using HarmonyLib;
using ItemManager;
using PieceManager;

namespace GBCustomTable
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class GBCustomTable : BaseUnityPlugin
    {
        private const string ModName = "GBCustomTable";
        private const string ModVersion = "0.1.0";
        private const string ModGUID = "odinplus.plugins.gbcustomtable";

        public void Awake()
        {


            BuildPiece Custom_Sky_Forge = new("customforgestone", "Custom_Sky_Forge");
            Custom_Sky_Forge.Name.English("Magic Crystal Table");
            Custom_Sky_Forge.Description.English("A black marble crystal");
            Custom_Sky_Forge.RequiredItems.Add("BlackMarble", 10, true);
            Custom_Sky_Forge.Category.Add(BuildPieceCategory.Crafting);

            BuildPiece Custom_Table_Ext1 = new("customforgestone", "Custom_Table_Ext1");
            Custom_Table_Ext1.Name.English("Table Ext 1");
            Custom_Table_Ext1.Description.English("A black marble crystal");
            Custom_Table_Ext1.RequiredItems.Add("BlackMarble", 2, true);
            Custom_Table_Ext1.Category.Add(BuildPieceCategory.Crafting);
            Custom_Table_Ext1.Extension.Set("Custom_Sky_Forge", 8);

            BuildPiece Custom_Table_Ext2 = new("customforgestone", "Custom_Table_Ext2");
            Custom_Table_Ext2.Name.English("Table Ext 2");
            Custom_Table_Ext2.Description.English("A custom table ext 2");
            Custom_Table_Ext2.RequiredItems.Add("BlackMarble", 2, true);
            Custom_Table_Ext2.Category.Add(BuildPieceCategory.Crafting);
            Custom_Table_Ext2.Extension.Set("Custom_Sky_Forge", 8);

            BuildPiece Custom_Table_Ext3 = new("customforgestone", "Custom_Table_Ext3");
            Custom_Table_Ext3.Name.English("Table Ext 3");
            Custom_Table_Ext3.Description.English("A custom table ext 3");
            Custom_Table_Ext3.RequiredItems.Add("BlackMarble", 2, true);
            Custom_Table_Ext3.Category.Add(BuildPieceCategory.Crafting);
            Custom_Table_Ext3.Extension.Set("Custom_Sky_Forge", 8);

            BuildPiece Custom_BlackForge_Ext_1 = new("customforgestone", "Custom_BlackForge_Ext_1");
            Custom_BlackForge_Ext_1.Name.English("Custom Blackforge Ext1");
            Custom_BlackForge_Ext_1.Description.English("A blackforge ext 1");
            Custom_BlackForge_Ext_1.RequiredItems.Add("YggdrasilWood", 10, true);
            Custom_BlackForge_Ext_1.RequiredItems.Add("BlackCore", 2, true);
            Custom_BlackForge_Ext_1.Crafting.Set(PieceManager.CraftingTable.BlackForge);
            Custom_BlackForge_Ext_1.Category.Add(BuildPieceCategory.Crafting);
            Custom_BlackForge_Ext_1.Extension.Set(PieceManager.CraftingTable.BlackForge, 8);

            BuildPiece Custom_BlackForge_Ext_2 = new("customforgestone", "Custom_BlackForge_Ext_2");
            Custom_BlackForge_Ext_2.Name.English("Custom Blackforge Ext2");
            Custom_BlackForge_Ext_2.Description.English("A blackforge ext 2");
            Custom_BlackForge_Ext_2.RequiredItems.Add("YggdrasilWood", 10, true);
            Custom_BlackForge_Ext_2.RequiredItems.Add("BlackCore", 2, true);
            Custom_BlackForge_Ext_2.Crafting.Set(PieceManager.CraftingTable.BlackForge);
            Custom_BlackForge_Ext_2.Category.Add(BuildPieceCategory.Crafting);
            Custom_BlackForge_Ext_2.Extension.Set(PieceManager.CraftingTable.BlackForge, 8);

            BuildPiece Custom_Magetable_Ext_1 = new("customforgestone", "Custom_Magetable_Ext_1");
            Custom_Magetable_Ext_1.Name.English("Custom Magetable Ext1");
            Custom_Magetable_Ext_1.Description.English("A magetable ext 1");
            Custom_Magetable_Ext_1.RequiredItems.Add("YggdrasilWood", 10, true);
            Custom_Magetable_Ext_1.RequiredItems.Add("BlackCore", 2, true);
            Custom_Magetable_Ext_1.Crafting.Set(PieceManager.CraftingTable.MageTable);
            Custom_Magetable_Ext_1.Category.Add(BuildPieceCategory.Crafting);
            Custom_Magetable_Ext_1.Extension.Set(PieceManager.CraftingTable.MageTable, 8);

            BuildPiece Custom_Magetable_Ext_2 = new("customforgestone", "Custom_Magetable_Ext_2");
            Custom_Magetable_Ext_2.Name.English("Custom Magetable Ext2");
            Custom_Magetable_Ext_2.Description.English("A magetable ext 2");
            Custom_Magetable_Ext_2.RequiredItems.Add("YggdrasilWood", 10, true);
            Custom_Magetable_Ext_2.RequiredItems.Add("BlackCore", 2, true);
            Custom_Magetable_Ext_2.Crafting.Set(PieceManager.CraftingTable.MageTable);
            Custom_Magetable_Ext_2.Category.Add(BuildPieceCategory.Crafting);
            Custom_Magetable_Ext_2.Extension.Set(PieceManager.CraftingTable.MageTable, 8);

            Item Custom_Eitr_Powerup = new Item("customforgestone", "Custom_Eitr_Powerup");
            Custom_Eitr_Powerup.Name.English("Custom Eitr Powerup");
            Custom_Eitr_Powerup.Description.English("A custom Eitr Food");
            Custom_Eitr_Powerup.Crafting.Add("Custom_Sky_Forge", 30);
            Custom_Eitr_Powerup.RequiredItems.Add("SwordCheat", 1);
            Custom_Eitr_Powerup.Configurable = Configurability.Full;
            Custom_Eitr_Powerup.CraftAmount = 1;



        }
    }
}



